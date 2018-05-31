using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework.PageObjects;
using OpenQA.Selenium;
using Framework.Driver;
using Framework.Helpers.Interfaces;
using Framework.Helpers.Classes;
using AventStack.ExtentReports;

namespace SeleniumFirst
{
    [TestClass]
    public class UnitTest1
    {
        private Pages pages;
        private MyWebDriver _driver;
        private TestCaseHandler _testCaseHandler;
        private BasicReport report;
        private ScreenshotGenerator _screenShotGenerator;

        [TestMethod]
        public void NavigateToLogin()
        {
            Pages.MainPage.NavigateToLogin();
            Assert.IsTrue(Pages.LoginPage.IsPageDisplayed(), "Login Page with correct header is not being displayed");

        }
        [TestMethod]
        public void NavigateToHome()
        {
            Pages.MainPage.NavigateToLogin();
            Pages.MainPage.NavigateToHome();
            Assert.IsTrue(Pages.MainPage.IsOn("CURA Healthcare Service"), "Main page with correct title is not being displayed");
        }
        [TestMethod]
        public void MakeAppointment()
        {

            Pages.MainPage.MakeAppointment();
            Pages.LoginPage.Login();
            Pages.AppointmentPage.SelectFacility("Tokyo CURA Healthcare Center");
            Pages.AppointmentPage.ApplyForHospitalReadMissions(true);
            Pages.AppointmentPage.SelectHealthCareProgram("Medicaid");
            Pages.AppointmentPage.SelectVisitDate("22/05/2018");
            Pages.AppointmentPage.EnterComment("This is a test");
            //Now we have to book the appointment before we assert the appointment is confirmed
            Pages.AppointmentPage.BookAppointment();
            Assert.IsTrue(Pages.SummaryPage.IsPageDisplayed(), "Appointment Confirmation is not displayed; appointment not booked");

        }
        [TestMethod]
        public void MakeAppointment_WrappedTestCaseHandler()
        {
            _testCaseHandler.Invoke<Action>(() =>
            {
                report.Create("Book Appointment");
                report.LogInfo("Selecting to make appointment");
                Pages.MainPage.MakeAppointment();
                report.LogInfo("Attempting to login");
                Pages.LoginPage.Login();
                report.LogInfo("Selecting facility");
                Pages.AppointmentPage.SelectFacility("Tokyo CURA Healthcare Center");
                report.LogInfo("Checking to apply hospital read missions");
                Pages.AppointmentPage.ApplyForHospitalReadMissions(true);
                report.LogInfo("Selecting healthcare program");
                Pages.AppointmentPage.SelectHealthCareProgram("Medicaid");
                report.LogInfo("Selecting visitation date");
                Pages.AppointmentPage.SelectVisitDate("22/05/2018");
                report.LogInfo("Entering comments");
                Pages.AppointmentPage.EnterComment("This is a test");
                report.LogInfo("Book appointment");
                Pages.AppointmentPage.BookAppointment();
                report.LogInfo("Verifying appointment confirmation has been displayed");
                Assert.IsTrue(Pages.SummaryPage.IsPageDisplayed(), "Appointment Confirmation is not displayed; appointment not booked");
            }, _driver, report);
            report.Pass("Succefully booked appontment");

        }
        [TestInitialize]
        public void Setup()
        {
            MyWebDriver driver = new MyWebDriver();
            driver.GetDriver();
            _driver = driver;
            _testCaseHandler = new TestCaseHandler(_driver);
            report = new BasicReport();
            report.StartReport();
            _screenShotGenerator = new ScreenshotGenerator(_driver);



        }
        [TestCleanup]
        public void Teardown()
        {

            if (report.Status == Status.Fail)
            {
                string screenShotPath = _screenShotGenerator.Capture("Screenshot");
                report.AddScreenShotCapture(screenShotPath);
            }

            report.EndReport();
            if (_driver != null)
            {
                _driver.Quit();
            }

        }

        public Pages Pages
        {
            get
            {
                pages = new Pages(_driver);
                return pages;
            }
        }
     
    }
}
