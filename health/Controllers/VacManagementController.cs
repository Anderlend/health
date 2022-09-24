using health.Model;
using Microsoft.AspNetCore.Mvc;

namespace health.Controllers
{

    [ApiController]
    [Route("vac-management/[controller]")]
    public class UserVacController : ControllerBase
    {
        private readonly ILogger<UserVacController> _logger;

        public UserVacController(ILogger<UserVacController> logger)
        {
            _logger = logger;
        }

        [HttpPost("{userId}", Name = "UserVac")]
        public UserVac Save([FromBody, FromQuery] UserVac m, Guid userId)
        {
            // I am just returning the posted model as it is. 
            // You may do other stuff and return different response.
            // Ex : missileService.LaunchMissile(m);

            return Helper.ParseJsonToDB("users.json", m, userId);

        }


    }
}
