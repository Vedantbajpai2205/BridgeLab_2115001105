using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BusinessLayer.Interface;
using Microsoft.Extensions.Logging;
using ModelLayer.DTO;
using RepositoryLayer.Interface;
using RepositoryLayer.Service;

namespace BusinessLayer.Service
{
    public class RegisterHelloBL : IRegisterHelloBL
    {
        private readonly IRegisterHelloRL _registerHelloRL;
        private readonly ILogger<RegisterHelloBL> _logger;

        public RegisterHelloBL(IRegisterHelloRL registerHelloRL, ILogger<RegisterHelloBL> logger)
        {
            _registerHelloRL = registerHelloRL;
            _logger = logger;
            _logger.LogInformation("Business Layer started");
            _logger.LogInformation($"Logger Testing in Business Layer with name: {_logger}");

        }

        public string registration(string name)
        {
            _logger.LogInformation("Registration method called with name: {Name}", name);
            string result = "Data from business layer " + _registerHelloRL.GetHello(name);
            _logger.LogInformation("Registration method completed with result: {Result}", result);
            return result;
        }

        public bool loginuser(LoginDTO loginDTO)
        {
            _logger.LogInformation("Login method called with username: {Username}", loginDTO.username);
            var result = _registerHelloRL.getUsernamePassword(loginDTO);
            bool isValid = result.username == loginDTO.username && result.password == loginDTO.password;
            _logger.LogInformation("Login method completed. IsValid: {IsValid}", isValid);
            return isValid;
        }
    }
}
