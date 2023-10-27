using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NationalParkApi.Models;
using System.Linq;

namespace NationalParkApi.Controllers
{
[Route("api/[controller]")]
[ApiController]
public class NationalParksController : ControllerBase
{
  private readonly NationalParkApiContext _db;

  public NationalParksController(NationalParkApiContext db)
  {
    _db = db;
  }

  // GET - return list of all National Parks in db
  [HttpGet]
  public async Task<ActionResult<IEnumerable<NationalPark>>> Get(int page = 1, int pageSize = 10)
  {
    var totalCount = await _db.NationalParks.CountAsync();
    var totalParks = (int)Math.Ceiling((decimal)totalCount / pageSize);
    var parksPerPage = await _db.NationalParks
        .Skip((page-1) * pageSize)
        .Take(pageSize)
        .ToListAsync();

    return parksPerPage;
  }

  // GET: api/NationalParks/5
  [HttpGet("{id}")]
    public async Task<ActionResult<NationalPark>> GetNationalPark(int id)
    {
      NationalPark national = await _db.NationalParks.FindAsync(id);

      if (national == null)
      {
        return NotFound();
      }

      return national;
    }

      // POST api/NationalParks
    [HttpPost]
    public async Task<ActionResult<NationalPark>> Post(NationalPark national)
    {
      _db.NationalParks.Add(national);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetNationalPark), new { id = national.NationalParkId }, national);
    }

    // PUT: api/NationalParks/3
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, NationalPark national)
    {
      if (id != national.NationalParkId)
      {
        return BadRequest();
      }

      _db.NationalParks.Update(national);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!NationalParkExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    private bool NationalParkExists(int id)
    {
      return _db.NationalParks.Any(entry => entry.NationalParkId == id);
    }

    // DELETE: api/NationalParks/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteNationalPark(int id)
    {
      NationalPark national = await _db.NationalParks.FindAsync(id);
      if (national == null)
      {
        return NotFound();
      }

      _db.NationalParks.Remove(national);
      await _db.SaveChangesAsync();

      return NoContent();
    }
}
}