using Microsoft.AspNetCore.Mvc;

namespace HelloApi.Controllers{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase{

        [HttpGet]
        public string Get(){
            return "Hello World, API";
        }
    }
}