using Framework.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.PageObjects
{
    public class Navigation : MyWebDriver
    {
        IWebDriver _driver;
        public Navigation(MyWebDriver driver)
        {
            _driver = driver;
        }
        public void NavigateToHome()
        {
            SelectNavMenu();
            IWebElement element = _driver.FindElement(By.LinkText("Home"));
            element.Click();
        }
        public void NavigateToLogin()
        {
            SelectNavMenu();
            IWebElement element = _driver.FindElement(By.LinkText("Login"));
            element.Click();
        }
        public void SelectNavMenu()
        {
            IWebElement element = _driver.FindElement(By.Id("menu-toggle"));
            element.Click();

        }
        public bool IsOn(string pageTitle)
        {
            if (!_driver.Title.Equals(pageTitle))
            {
                return false;
            }
            return true;

        }
    }
}
