using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    class Login
    {
        public Login(IBrowsers driver)
        {
            var loginPage = new LoginPage(driver);
            loginPage.Navigation(1);
            loginPage.UsernameFill(Constants.Usernames[0]);
            loginPage.PasswordFill(Constants.Passwords[0]);
            loginPage.LoginButton();
        }
    }
}
