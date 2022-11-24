using Microsoft.AspNetCore.Mvc;

namespace blazorTest.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private static List<Comic> comics = new List<Comic>
        {
            new Comic() {Id = 1, Name = "Marvel"},
            new Comic() {Id = 2, Name = "DCS"},
            new Comic() {Id = 3, Name = "Melanie"},
        };

        private static List<SuperHero> heroes = new List<SuperHero>
        {
            new SuperHero() {Id = 1, FirstName = "Luca", LastName = "Riccardi", HeroName = "Your man", Comic = comics[0]},
            new SuperHero() {Id = 2, FirstName = "DCS", LastName = "Sophus", HeroName = "10xProgrammer", Comic = comics[1]},
            new SuperHero() {Id = 3, FirstName = "Melanie", LastName = "Nielson", HeroName = "Blond girl", Comic = comics[2]}
        };
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetSuperHeroes()
        {
            return Ok(heroes);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> GetSuperHero(int id)
        {
            return Ok(heroes.FirstOrDefault(x => x.Id == id));
        }
    }
}