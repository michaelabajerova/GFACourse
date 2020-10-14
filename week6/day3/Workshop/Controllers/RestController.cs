using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Workshop.Models
{
    [Route("api")]
    public class RestController : Controller
    {
        public int idCount = 0;
        [HttpGet("greeting")]
        public Greeting Greet(string name)
        {          
            idCount++;
            Greeting greet = new Greeting() {ID = idCount, Content = "Hello " + name};
            return greet;
        }
    }
}
