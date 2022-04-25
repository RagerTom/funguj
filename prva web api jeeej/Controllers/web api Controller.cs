using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace prva_web_api_jeeej.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class web_api_Controller : ControllerBase
    {

        private static List<web_api> ziak = new List<web_api>
            {
                new web_api {
                    Id = 1,
                    FirstName = "Janko",
                    LastName = "Mrkvicka",
                    Age = 20
                }
            };
        [HttpGet]
        [Route("ziaci")]
        public async Task<ActionResult<List<web_api>>> Get()
        {


            return Ok(ziak);
        }

        [HttpGet]
        
        public async Task<ActionResult<List<web_api>>> addZiak(int id, string firstName, string lastName, int age)
        {
            web_api api = new web_api();

            api.Id = id;
            api.FirstName = firstName;
            api.LastName = lastName;
            api.Age = age;

            ziak.Add(api);
            return Ok(ziak);
        }
    }

}
