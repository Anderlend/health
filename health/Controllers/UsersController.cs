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
        //public Users user = new Users()
        //{
        //    Id = "d54ed580-a5e6-4f75-bfd7-ed2d29ffd6ca",
        //    BirthDate = "1970-01-01",
        //    FirstName = "",
        //    Gender = "cccc",
        //    LastName = "sss"
        //};

        static string contentResp = @"{
  'users': [
    {
      'id': '392d86f8-2c81-48bc-9ca6-848862cc4afe',
      'firstName': 'Mask',
      'lastName': 'Bond',
      'gender': 'Male',
      'birthDate': '1970-01-01'
    },
    {

      'id': '37b33826-5aa5-4fe0-96d9-42c65a43e067',
      'firstName': 'Ahtiom',
      'lastName': 'Belka',
      'gender': 'Male',
      'birthDate': '1970-01-01'
    },
    {
      'id': 'd54ed580-a5e6-4f75-bfd7-ed2d29ffd6ca',
      'firstName': 'Olgich',
      'lastName': 'Svyshch',
      'gender': 'Female',
      'birthDate': '1970-01-01'
    },
    {
      'id': '32aeb91e-7663-4b5f-9e73-54af9aa3e70f',
      'firstName': 'Katsya',
      'lastName': 'Logoyda',
      'gender': 'Female',
      'birthDate': '1970-01-01'
    }

  ]
}";

        GetUsers respClass = JsonConvert.DeserializeObject<GetUsers>(contentResp);
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
