using Microsoft.AspNetCore.Mvc;
using POPOST.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace POPOST.Controllers
{
    [Route("")]
    [ApiController]
    public class BoxController : ControllerBase
    {
        private readonly BoxDbContext _context;
        public BoxController(BoxDbContext context)
        {
            _context = context;
        }
        // GET: api/<Box>
        [HttpGet]
        public ActionResult<IEnumerable<Box>> Get()
        {
            return _context.Box.ToList();
        }

        // GET api/<Box>/date
        [HttpGet("{date}")]
        public ActionResult<Box> Get(DateTimeOffset date)
        {
            var Box = _context.Box.Find(date);
            if (Box == null)
            {
                return NotFound();
            }
            return Box;
        }

        //Get api/<Box>/last
        [HttpGet("last")]
        public ActionResult<Box> GetLast()
        {
            var Box = _context.Box.OrderByDescending(b => b.Date).FirstOrDefault();
            if (Box == null)
            {
                return NotFound();
            }
            return Box;
        }

        // POST api/<Box>
        [HttpPost]
        public async Task<ActionResult<Box>> Post([FromBody] Box box)
        {
            if(box == null)
            {
                return BadRequest();
            }
            _context.Box.Add(box);
            await _context.SaveChangesAsync();
            return CreatedAtAction("Get", new { date = box.Date }, box);
        }
    }
}
