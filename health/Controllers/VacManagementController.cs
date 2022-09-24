using health.Model;
using Microsoft.AspNetCore.Mvc;

namespace health.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserVacController : ControllerBase
    {
        private readonly ILogger<UserVacController> _logger;

        public UserVacController(ILogger<UserVacController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "UserVac")]
        public User Save([FromBody] User m)
        {
            // I am just returning the posted model as it is. 
            // You may do other stuff and return different response.
            // Ex : missileService.LaunchMissile(m);


            return m;

        }


    }
}
