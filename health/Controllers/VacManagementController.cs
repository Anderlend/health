using health.Model;
using Microsoft.AspNetCore.Mvc;

namespace health.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class VacManagementController : ControllerBase
    {
        private readonly ILogger<VacManagementController> _logger;

        public VacManagementController(ILogger<VacManagementController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "UserVac")]
        public string Get()
        {
            return " ";
        }
    }


}
