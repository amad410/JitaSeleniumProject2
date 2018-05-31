using Framework.Driver;
using Framework.Helpers.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Helpers.Classes
{
    public class TestCaseHandler :ITestCaseHandler
    {
        MyWebDriver _driver;
     
        public TestCaseHandler(MyWebDriver driver)
        {
            _driver = driver;
        }

        public void Invoke<T>(Action testCase, MyWebDriver driver, BasicReport report)
        {
            Invoke(testCase, driver, report);
        }
        public void Invoke(Action testStep, MyWebDriver driver, BasicReport report)
        {
            try
            {
                testStep();
                
            }
            catch (NoSuchElementException ex)
            {

                
                ATNoSuchElementException exception = new ATNoSuchElementException(string.Format("{0}:{1}", "Unable to identify element using selenium locator provided.", ex.Message), ex.InnerException);
                report.Fail(exception);
                throw exception;



            }
            catch(ElementNotVisibleException ex)
            {
                ATElementNotVisibleException exception = new ATElementNotVisibleException(string.Format("{0}:{1}", "Element not visible in the DOM. Check to see if element is hidden.", ex.Message), ex.InnerException);

                report.Fail(exception);
                throw exception;
            }
            catch (ElementNotSelectableException ex)
            {
                ATElementNotSelectableException exception = new ATElementNotSelectableException(string.Format("{0}:{1}", "Although element is present in the DOM, it may be disabled (cannot be clicked/selected).", ex.Message), ex.InnerException);

               report.Fail(exception);
                throw exception;
            }
            catch (InvalidElementStateException ex)
            {
                ATInvalidElementStateException exception = new ATInvalidElementStateException(string.Format("{0}:{1}", "You are performing an operation using this element that is no applicable.", ex.Message), ex.InnerException);

               report.Fail(exception);
                throw exception;
            }
            catch (TimeoutException ex)
            {

                ATTimeoutException exception = new ATTimeoutException(string.Format("{0}:{1}", "This comand did not complete in enough time.", ex.Message), ex.InnerException);

               report.Fail(exception);
                throw exception;
            }
            catch (WebDriverException ex)
            {
                throw new ATWebDriverException(string.Format("{0}:{1}", "The WebDriver is performing the action immediately after ‘closing’ the browser.", ex.Message), ex.InnerException);
            }
            catch(Exception ex)
            {
                throw ex;

            }
            finally
            {
                //_driver.Quit();
                //GC.Collect();
                
            }


        }
    }
}
