using System.Threading.Tasks;
using dockertraining_compose_francisco_sosa_v1.Models;
using Microsoft.AspNetCore.Mvc;

namespace dockertraining_compose_francisco_sosa_v1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly Context db;

        public MovieController(Context context)
        {
            db = context;
        }

        // GET: api/Movies
        [HttpGet]
        public IActionResult Get()
        {
            var movies = db.Movies;

            return Ok(movies);
        }

        // POST: api/Movies
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await db.AddAsync(movie);
            await db.SaveChangesAsync();
            return Ok(movie.Id);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Movie>> Delete(int id)
        {
            var movie = await db.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }

            db.Movies.Remove(movie);
            await db.SaveChangesAsync();

            return movie;
        }
    }
}