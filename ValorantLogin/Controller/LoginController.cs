using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ValorantLogin.Model;
using ValorantLogin.View;

namespace ValorantLogin.Controller
{
    class LoginController
    {
        private LoginModel model;
        private LoginForm view;

        public LoginController(LoginForm view) {
            this.view = view;
            model = new LoginModel();
        }
        public void CheckResult() { 
            model.checkLogin(view.txtEmail.Text, view.txtPassword.Password);
            bool result = model.getResult();
            if (result)
            {
                HomeWindow home = new HomeWindow();
                home.Show();
                view.Close();
            }
            else
            {
                MessageBox.Show("Username / Password Invalid!");
                view.txtEmail.Focus();
            }
        }
    }
}
