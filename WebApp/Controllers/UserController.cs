using Microsoft.AspNetCore.Mvc;

namespace Controller.UserController
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        

        [HttpGet]
        [Route("sayhi")]
        public string SayHi()
        {
            return "Hiiiiiii";
        }
    }
}