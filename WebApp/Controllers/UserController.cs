using Microsoft.AspNetCore.Mvc;

namespace MyWebAPI.Controller
{
    [Route("api/")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;
        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }


        [HttpGet]
        [Route("getallusers")]
        public IActionResult GetAllUsers()
        {
            var users = _repository.GetAllUser();
            return Ok(users);
        }


        [HttpGet]
        [Route("getpagingusers/{skip}/{take}")]
        public IActionResult GetPaging(int skip,int take)
        {
            var users = _repository.GetPaging(skip,take);
            return Ok(users);
        }

    }
}