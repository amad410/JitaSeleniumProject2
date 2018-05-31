using Framework.ControlLibs.Extensions;
using Framework.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.PageObjects
{
    public class LoginPage : Navigation
    {
        IWebDriver _driver;
        string pageHeader = "Login";
        public LoginPage(MyWebDriver driver):base(driver)
        {
            _driver = driver;
        }
        /// <summary>
        /// This method performs the login accepting user name and password from app.config.
        /// Then enters the credentials into the fields and clicks login button.
        /// </summary>
        public void Login()
        {
            var username = ConfigurationManager.AppSettings["username"].ToString();
            var password = ConfigurationManager.AppSettings["password"].ToString();

            IWebElement userNameField = _driver.FindElement(By.XPath("//input[@id='txt-username']"));
            IWebElement passWordField = _driver.FindElement(By.XPath("//input[@id='txt-password']"));
            userNameField.EnterText(username, "username element");
            passWordField.EnterText(password, "password element");

            IWebElement loginButton = _driver.FindElement(By.Id("btn-login"));
            loginButton.Click();

        }
        /// <summary>
        /// This method toggles the remember me option.
        /// </summary>
        public void ToggleRememberMe()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// This method returns whether you are on the page displayed
        /// </summary>
        /// <returns></returns>
        public bool IsPageDisplayed()
        {
            if (!_driver.FindElement(By.TagName("h2")).Text.Equals(pageHeader))
            {
                return false;
            }
            return true;

        }
    }
}
