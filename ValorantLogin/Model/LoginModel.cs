using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValorantLogin.Model
{
    class LoginModel
    {
        private bool result;
        public bool getResult()
        {
            return this.result;
        }

        public void checkLogin(string email, string password)
        {
            if(email == "Fliw" && password == "Fliw123")
            {
                this.result = true;
            }
            else
            {
                this.result = false;
            }
        }
    }
}
