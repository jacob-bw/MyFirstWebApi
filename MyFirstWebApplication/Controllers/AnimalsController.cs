using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstWebApi.Models;

namespace MyFirstWebApi.Controllers
{
    [Route("api/animals")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllAnimals()
        {
            var animals = new List<Animal>
            {
                new Animal {Name = "Steve", Type = "Elephant", Weight = 2000},
                new Animal {Name = "George", Type = "Monkey", Weight = 60},
                new Animal {Name = "Bill", Type = "Zebroid", Weight = 300},
            };
            return Ok(animals);
        }



    }
}