using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Service; //to add business layer 
using ModelLayer.DTO;
using BusinessLayer.Interface;
using RepositoryLayer.Service;

namespace HelloApp1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        private readonly IRegisterHelloBL _registerHelloBL;
        private readonly ILogger<LoggerManager<HelloController>> _logger;

        public HelloController(IRegisterHelloBL registerHelloBL, ILogger<LoggerManager<HelloController>> logger)
        {
            _registerHelloBL = registerHelloBL;
            _logger = logger;
            _logger.LogInformation("Hello Controller Started");
            _logger.LogInformation("Logger Testing in Controller Layer");

        }

        [HttpGet]
        public string Get()
        {
            _logger.LogInformation("Get method called");
            string result = _registerHelloBL.registration("Yash");
            _logger.LogInformation("Get method completed with result: {Result}", result);
            return result;
        }

        [HttpPost]
        public IActionResult LoginUser(LoginDTO loginDTO)
        {
            _logger.LogInformation("LoginUser method called with username: {Username}", loginDTO.username);
            bool result = _registerHelloBL.loginuser(loginDTO);

            if (result)
            {
                _logger.LogInformation("Login Successful username: {Username}", loginDTO.username);
                return Ok("Login Successful");
            }
            _logger.LogWarning("Login Failed username: {Username}", loginDTO.username);
            return NotFound("Login Failed");
        }
    }
}
