using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ParksLookup.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParksController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ParksController> _logger;

        public ParksController(ILogger<ParksController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Parks> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Parks
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
