using Framework.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Helpers.Classes
{
    public class ScreenshotGenerator
    {
        private IWebDriver _driver;
        public ScreenshotGenerator(MyWebDriver driver)
        {
            _driver = driver.Driver;
        }
        public string Capture(string screenShotName)
        {
            ITakesScreenshot ts = (ITakesScreenshot)_driver;
            Screenshot screenshot = ts.GetScreenshot();
            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string finalpth = pth.Substring(0, pth.LastIndexOf("bin")) + "ErrorScreenshots\\" + screenShotName + ".png";
            string localpath = new Uri(finalpth).LocalPath;
            screenshot.SaveAsFile(localpath, OpenQA.Selenium.ScreenshotImageFormat.Png);
            //return localpath;
            return finalpth;
        }
    }
}
