using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyWebAPI.DTOs;

namespace MyWebAPI.Controller
{
    [Route("api/")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;
        private readonly UserManager<IdentityUser> _userManager;
        public UserController(IUserRepository repository,UserManager<IdentityUser> userManager)
        {
            _repository = repository;
            _userManager = userManager;
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

        [HttpPost("register")]
        public IActionResult Register(RegisterDTO dto)
        {
            var resault = _repository.Register(dto);
            if(resault==true)
            {
                return Created();
            }
            else
            {
                return BadRequest();
            }

   
        }

        [HttpPost("upload")]
        public IActionResult UploadAvatar(IFormFile frm)
        {
            string path= @"C:\Users\test\Pictures";
            ImageExtention.SaveToServer(frm,path);
            return Ok();
        }



        [HttpPost("login")]
        public IActionResult Login(LoginDTO dto)
        {
            var user = _userManager.FindByNameAsync(dto.UserName).Result;
            string token = TokenGenerator.GenerateEncodedToken(user);
            if(user.PasswordHash == HashGenerator.Generate(dto.Password))
            {
                return Ok(token);
            }
            else
            {
                return BadRequest();
            }
        }

    }
} 