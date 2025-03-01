using ModelLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interface
{
    public interface IRegisterHelloRL
    {

        public string GetHello(string name);

        public LoginDTO getUsernamePassword(LoginDTO loginDTO);
        
    }
}

