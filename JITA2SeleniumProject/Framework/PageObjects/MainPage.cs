using Framework.Driver;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.PageObjects
{
    public class MainPage : Navigation
    {
        IWebDriver _driver;
        public MainPage(MyWebDriver driver) : base(driver)
        {
            _driver = driver;
        }
        /// <summary>
        /// This method selects to make an appointment on the main page.
        /// </summary>
        public void MakeAppointment()
        {
            IWebElement element = _driver.FindElement(By.Id("btn-make-appointment1334"));
            element.Click();
        }
        
    }
}
