using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NationalParks.Model;

namespace NationalParkApi.Controllers
{
[Route("api/controller")]
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
  public async Task<ActionResult<IEnumerable<NationalPark>>> Get()
  {
    return await _db.NationalParks.ToListAsync()
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
}
}