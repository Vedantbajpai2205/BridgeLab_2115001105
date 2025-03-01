using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;
using RepositoryLayer.Interface;

namespace RepositoryLayer.Service
{
    public class RegisterHelloRL : IRegisterHelloRL
    {
        private readonly ILoggerManager<LoggerManager<RegisterHelloRL>> _logger;

        public RegisterHelloRL(ILoggerManager<LoggerManager<RegisterHelloRL>> logger)
        {
            _logger = logger;
            _logger.LogInfo(" Hello App Repository Layer started");
            _logger.LogInfo("Logger Testing in Repository Layer");

        }

        public string GetHello(string name)
        {
            _logger.LogInfo("Repository Layer: GetHello Method Called");
            return name + " hello from repository layer";
        }

        public LoginDTO getUsernamePassword(LoginDTO loginDTO)
        {
            _logger.LogInfo($"Repository Layer: Login attempt by {loginDTO.username}");
            loginDTO.username = "root";
            loginDTO.password = "root";
            return loginDTO;
        }
    }
}

