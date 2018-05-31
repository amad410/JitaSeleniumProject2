using Framework.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.PageObjects
{
    public class SummaryPage : Navigation
    {
        IWebDriver _driver;
        string pageHeader = "Appointment Confirmation";
        public SummaryPage(MyWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

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
