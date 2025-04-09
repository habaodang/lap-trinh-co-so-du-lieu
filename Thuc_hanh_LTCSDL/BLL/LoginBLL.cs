using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class LoginBLL
    {
        private LoginDTA loginDTA = new LoginDTA();

        public bool login(Account acc)
        {
            return loginDTA.login(acc);
        }
    }
}
