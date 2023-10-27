using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NationalParkApi.Models;
using System.Linq;

namespace NationalParkApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class StateParksController : ControllerBase
  {
    private readonly NationalParkApiContext _db;

    public StateParksController(NationalParkApiContext db)
    {
      _db = db;
    }

    // GET - return list of all State Parks in db
[HttpGet]
  public async Task<ActionResult<IEnumerable<StatePark>>> Get(int page = 1, int pageSize = 10)
  {
    var totalCount = await _db.StateParks.CountAsync();
    var totalParks = (int)Math.Ceiling((decimal)totalCount / pageSize);
    var parksPerPage = await _db.StateParks
        .Skip((page-1) * pageSize)
        .Take(pageSize)
        .ToListAsync();

    return parksPerPage;
  }
  // GET: api/StateParks/5
  [HttpGet("{id}")]
    public async Task<ActionResult<StatePark>> GetStatePark(int id)
    {
      StatePark state = await _db.StateParks.FindAsync(id);

      if (state == null)
      {
        return NotFound();
      }

      return state;
    }

      // POST api/StateParks
    [HttpPost]
    public async Task<ActionResult<StatePark>> Post(StatePark state)
    {
      _db.StateParks.Add(state);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetStatePark), new { id = state.StateParkId }, state);
    }

     // PUT: api/StateParks/3
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, StatePark state)
    {
      if (id != state.StateParkId)
      {
        return BadRequest();
      }

      _db.StateParks.Update(state);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!StateParkExists(id))
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

    private bool StateParkExists(int id)
    {
      return _db.StateParks.Any(entry => entry.StateParkId == id);
    }

    // DELETE: api/StateParks/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteStatePark(int id)
    {
      StatePark state = await _db.StateParks.FindAsync(id);
      if (state == null)
      {
        return NotFound();
      }

      _db.StateParks.Remove(state);
      await _db.SaveChangesAsync();

      return NoContent();
    }

  }
}