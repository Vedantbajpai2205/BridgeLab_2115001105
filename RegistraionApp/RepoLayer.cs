using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer1.DTO;

namespace RepositoryLayer1.Service
{
    public class RegisterationRL
    {
        private string databaseUsername = "root";
        private string databsePassword = "root";
        private string databaseEmail = "yash@123.com";
        private int databaseregId = 123;
        public RegisterationRL() { }

        public string GetHello(string name)
        {
            return name + "hello from repository layer";
        }
        public RegistrationDTO getUsernamePassword(RegistrationDTO registrationDTO)
        {
            registrationDTO.username = databaseUsername;
            registrationDTO.password = databsePassword;
            registrationDTO.email = databaseEmail;
            registrationDTO.regid = databaseregId;
            return registrationDTO;
        }
    }
}