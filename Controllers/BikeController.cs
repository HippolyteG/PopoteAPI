using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using POPOST.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace POPOST.Controllers
{
    [Route("/cb")]
    [ApiController]
    public class BikeController : ControllerBase
    {
        private readonly BoxDbContext _context;
        public BikeController(BoxDbContext context)
        {
            _context = context;
        }
        // GET: api/<Bike>
        [HttpGet]
        public ActionResult<IEnumerable<Bike>> Get()
        {
            return _context.Bike.ToList();
        }

        // GET api/<Bike>/id
        [HttpGet("{id}")]
        public ActionResult<Bike> Get(int id)
        {
            var Bike = _context.Bike.Find(id);
            if (Bike == null)
            {
                return NotFound();
            }
            return Bike;
        }

        // POST api/<Bike>
        [HttpPost]
        public async Task<ActionResult<Bike>> Post([FromBody] Bike Bike)
        {
            if(Bike == null)
            {
                return BadRequest();
            }
            _context.Bike.Add(Bike);
            await _context.SaveChangesAsync();
            return CreatedAtAction("Get", new { Id = Bike.Id }, Bike);
        }

        // PUT api/<Bike>/id
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Bike Bike)
        {
            if (id != Bike.Id)
            {
                return BadRequest();
            }
            _context.Entry(Bike).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Bike.Any(e => e.Id == id))
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
    }
}
