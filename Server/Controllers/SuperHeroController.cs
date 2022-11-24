using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace blazorTest.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        public static List<Comic> comics = new List<Comic>
        {
            new Comic() {Id = 1, Name = "Marvel"},
            new Comic() {Id = 1, Name = "DCS"},
            new Comic() {Id = 1, Name = "Melanie"},
        };
        public static List<SuperHero> heroes = new List<SuperHero>
        {
            new SuperHero() {Id = 1, FirstName = "Luca", LastName = "Riccardi", HeroName = "Your man", Comic = comics[0]},
            new SuperHero() {Id = 1, FirstName = "DCS"},
            new SuperHero() {Id = 1, FirstName = "Melanie"},
        };
    }
}
