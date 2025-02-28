using Microsoft.AspNetCore.Mvc;
using BusinessLayer1.Service; //to add business layer 
using ModelLayer1.DTO;

namespace RegistrationApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegistrationAppController : ControllerBase
    {
        RegisterationBL _registerationBL; // object of business layer class
        ResponseModel<string> response;
        public RegistrationAppController(RegisterationBL registerationBL)
        {
            _registerationBL = registerationBL;
        }
        [HttpGet]
        public string Get()
        {
            return _registerationBL.registration(" Registration-App "); //method being called from business layer (registration)
        }
        public IActionResult LoginUser(RegistrationDTO registrationDTO)
        {
            try
            {
                var response = new ResponseModel<string>();
                bool result = _registerationBL.loginuser(registrationDTO);
                if (result)
                {
                    response.Success = true;
                    response.Message = "Registered Successfully";
                    response.Data = registrationDTO.email;
                    return Ok(response);
                }
                response.Success = false;
                response.Message = "Registration Failed";
                response.Data = "";
                return NotFound("File Not Found.");
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Registration Failed";
                response.Data = ex.Message;
                return BadRequest("Username already exist.");

            }
            _registerationBL.Users.Add(registrationDTO);

             var users = _registerationBL.GetAllUsers();  // Synchronous
             return Ok(users);
          

        }
    }
}
