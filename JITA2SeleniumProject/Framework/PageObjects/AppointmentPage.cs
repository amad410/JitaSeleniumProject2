using Framework.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.PageObjects
{
    public class AppointmentPage : Navigation
    {
        IWebDriver _driver;
        string pageHeader = "Make Appointment";
        public AppointmentPage(MyWebDriver driver) : base(driver)
        {
            _driver = driver;
        }
        /// <summary>
        /// This method selects a facility option.
        /// </summary>
        /// <param name="facilityOption"></param>
        public void SelectFacility(string facilityOption)
        {
            IWebElement facilityElement = _driver.FindElement(By.Id("combo_facility"));
            SelectElement oSelect = new SelectElement(facilityElement);
            oSelect.SelectByText(facilityOption);
        }
        /// <summary>
        /// This method checks whether to apply for hospital read missions.
        /// </summary>
        /// <param name="optionToSelect"></param>
        public void ApplyForHospitalReadMissions(bool optionToSelect)
        {
            IWebElement checkbox = _driver.FindElement(By.Id("chk_hospotal_readmission"));
            if(optionToSelect == true)
            {
                if(checkbox.Selected != true)
                {
                    checkbox.Click();

                }
            }
        }
        /// <summary>
        /// This method selects a healthcare program.
        /// </summary>
        /// <param name="optionToSelect"></param>
        public void SelectHealthCareProgram(string optionToSelect)
        {

            ReadOnlyCollection<IWebElement> radioPrograms = _driver.FindElements(By.Name("programs"));

            foreach(IWebElement radioSelection in radioPrograms)
            {
                if(radioSelection.GetAttribute("value").Equals(optionToSelect))
                {
                    if(radioSelection.Selected != true)
                    {
                        radioSelection.Click();
                        break;
                    }
                    
                }
            }
           
        }
        /// <summary>
        /// This method books an appointment
        /// </summary>
        public void BookAppointment()
        {
            IWebElement bookApptBtn = _driver.FindElement(By.Id("btn-book-appointment"));
            bookApptBtn.Click();
        }

        /// <summary>
        /// This is a method for selecting visit date.
        /// </summary>
        /// <param name="date"></param>
        public void SelectVisitDate(DateTime date)
        {
            string convertedDate = date.ToString("dd'/'MM'/'yyyy");
            IWebElement calendarInput = _driver.FindElement(By.Id("txt_visit_date"));
            calendarInput.SendKeys(convertedDate);

        }
        /// <summary>
        /// This is an overloaded method for selecting a visit date.
        /// </summary>
        /// <param name="date"></param>
        public void SelectVisitDate(string date)
        {
            IWebElement calendarInput = _driver.FindElement(By.Id("txt_visit_date"));
            calendarInput.SendKeys(date);

        }
        /// <summary>
        /// This method enters a comment into the Comment field.
        /// </summary>
        /// <param name="comment"></param>
        public void EnterComment(string comment)
        {
            IWebElement commentArea = _driver.FindElement(By.Id("txt_comment"));
            commentArea.SendKeys(comment);

        }
        /// <summary>
        /// This method returns whether you are on the page displayed.
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
