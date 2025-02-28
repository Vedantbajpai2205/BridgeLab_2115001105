using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer1.DTO;
using RepositoryLayer1.Service;

namespace BusinessLayer1.Service
{
    public class RegisterationBL
    {
        RegisterationRL _registerationRL;
        public List<RegistrationDTO> Users { get; set; }
        public RegisterationBL(RegisterationRL registerationRL)
        {
            _registerationRL = registerationRL;
        }

        public string registration(string name)
        {
            //return "This is business layer data = "+name;
            return "Data from business layer " + _registerationRL.GetHello(name);
        }

        public bool loginuser(RegistrationDTO registrationDTO)
        {
            string frontendUsername = registrationDTO.username;
            string frontendPassword = registrationDTO.password;
            string frontendEmail = registrationDTO.email;
            int frontendregId = registrationDTO.regid;

            RegistrationDTO result = _registerationRL.getUsernamePassword(registrationDTO);

            bool res = checkUsernamePassword(frontendUsername, frontendPassword, frontendEmail, frontendregId, result);

            return res;
        }
        private bool checkUsernamePassword(string frontendUsername, string frontendPassword, string frontendEmail, int frontendregId, RegistrationDTO result)
        {
            if (frontendUsername == result.username && frontendPassword == result.password && frontendEmail == result.email && frontendregId == result.regid)
            {
                return true;
            }
            return false;
        }
        public List<RegistrationDTO> GetAllUsers()
        {
            return Users;
        }
    }
}