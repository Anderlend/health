using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace health.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FullInfoController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<FullInfoController> _logger;

        public FullInfoController(ILogger<FullInfoController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetFullInfo")]
        public IEnumerable<FullInfo> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new FullInfo
            {
                Date = DateTime.Now.AddDays(index),
                FirstName = "Qwerty",
                LastName = "Qwerty2",
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
