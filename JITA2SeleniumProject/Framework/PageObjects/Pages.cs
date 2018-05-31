using Framework.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.PageObjects
{
    public class Pages
    {
        private MyWebDriver _driver;
        private AppointmentPage _appointmentPage;
        private MainPage _mainPage;
        private Navigation _navigation;
        private LoginPage _loginPage;
        private SummaryPage _summaryPage;
        public Pages(MyWebDriver driver)
        {
            _driver = driver;
        }

        public AppointmentPage AppointmentPage
        {
            get
            {
                _appointmentPage = new AppointmentPage(_driver);
                return _appointmentPage;
            }
        }
        public MainPage MainPage
        {
            get
            {
                _mainPage = new MainPage(_driver);
                return _mainPage;
            }
        }
        public LoginPage LoginPage
        {
            get
            {
                _loginPage = new LoginPage(_driver);
                return _loginPage;
            }
        }
        public SummaryPage SummaryPage
        {
            get
            {
                _summaryPage = new SummaryPage(_driver);
                return _summaryPage;
            }
        }
        public Navigation Navigation
        {
            get
            {
                _navigation = new Navigation(_driver);
                return _navigation;
            }
        }

    }
}
