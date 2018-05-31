using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Driver
{
    public class MyWebDriver : IWebDriver
    {
        private IWebDriver _driver;

        public void GetDriver()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("http://demoaut.katalon.com/");

        }

        public void Close()
        {
            _driver.Close();
        }

        public void Quit()
        {
            _driver.Quit();
        }

        public IOptions Manage()
        {
            throw new NotImplementedException();
        }

        public INavigation Navigate()
        {
            throw new NotImplementedException();
        }

        public ITargetLocator SwitchTo()
        {
            throw new NotImplementedException();
        }

        public IWebElement FindElement(By by)
        {
            IWebElement elem = null;
            try
            {
                elem = Driver.FindElement(by);
                return elem;
            }
            catch (TimeoutException)
            {
                WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
                wait.PollingInterval = TimeSpan.FromMilliseconds(500);
                wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                elem = Driver.FindElement(by);
                return elem;
            }
            catch(StaleElementReferenceException)
            {
                WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
                wait.PollingInterval = TimeSpan.FromMilliseconds(500);
                wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                elem = Driver.FindElement(by);
                return elem;
            }
            catch (NoSuchElementException ex)
            {
                throw ex;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public IWebElement ATFindElement(By by)
        {
            IWebElement elem = null;
            try
            {
                elem = Driver.FindElement(by);
                return elem;
            }
            catch (TimeoutException)
            {
                WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
                wait.PollingInterval = TimeSpan.FromMilliseconds(500);
                wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                elem = Driver.FindElement(by);
                return elem;
            }
            catch (StaleElementReferenceException)
            {
                WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
                wait.PollingInterval = TimeSpan.FromMilliseconds(500);
                wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                elem = Driver.FindElement(by);
                return elem;
            }
            catch (NoSuchElementException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            ReadOnlyCollection<IWebElement> elements = null;
            try
            {
                elements = Driver.FindElements(by);
                return elements;
            }
            catch (TimeoutException)
            {
                WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
                wait.PollingInterval = TimeSpan.FromMilliseconds(500);
                wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                elements = Driver.FindElements(by);
                return elements;
            }
            catch (StaleElementReferenceException)
            {
                WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
                wait.PollingInterval = TimeSpan.FromMilliseconds(500);
                wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                elements = Driver.FindElements(by);
                return elements;
            }
            catch (NoSuchElementException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IWebDriver Driver
        {
            get
            {
                return _driver;
            }
        }

        public string Url { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Title
        {
            get
            {
                return _driver.Title;
            }
        }
            

        public string PageSource => throw new NotImplementedException();

        public string CurrentWindowHandle => throw new NotImplementedException();

        public ReadOnlyCollection<string> WindowHandles => throw new NotImplementedException();
    }
}
