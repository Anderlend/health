using Grpc.Core;
using health.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace health.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }
       
        [HttpGet(Name = "GetUsers")]
        public GetUsers Get()
        {
            return Helper.ParseJsonFromDB<GetUsers>("users.json");
        }
    }
    //[Route("api/[controller]")]
    //[ApiController]
    //public class UsersController : ControllerBase
    //{
    //    private readonly ILogger<UsersController> _logger;

    //    public UsersController(ILogger<UsersController> logger)
    //    {
    //        _logger = logger;
    //    }

    //    [HttpGet(Name = "GetUsers")]
    //    public Users Get()
    //    {
    //        return Helper.ParseJsonFromDB("scsc");
    //    }
    //}
}
