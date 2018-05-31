using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.MarkupUtils;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;

namespace Framework.Helpers.Classes
{
    public class BasicReport
    {
        public ExtentReports extent;
        public ExtentTest test;
        public Status status;
        public ExtentHtmlReporter htmlReporter;

        public BasicReport()
        {

        }

        public void StartReport()
        {
            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;

            string reportPath = projectPath + "Reports\\TestReport.html";

            htmlReporter = new ExtentHtmlReporter(reportPath);

            htmlReporter.Configuration().Theme = Theme.Dark;

            htmlReporter.Configuration().DocumentTitle = "Automation Report";

            htmlReporter.Configuration().ReportName = "Automation Report";

            htmlReporter.Configuration().JS = "$('.brand-logo').text('').append('<img src=D:\\Users\\jloyzaga\\Documents\\FrameworkForJoe\\FrameworkForJoe\\Capgemini_logo_high_res-smaller-2.jpg>')";

            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);

        }
        public void Create(string testName)
        {
            test = extent.CreateTest(testName, "This is a test");
        }

        public void LogInfo(string info)
        {
            test.Info(info);
        }
        public void LogInfo(string info, IMarkup markup)
        {
            test.Log(status, markup);
        }
        public void AddScreenShotCapture(string path)
        {
            test.AddScreenCaptureFromPath(path);

        }
        public void LogInfo(Status status, string ex)
        {
            test.Log(status, ex);
        }
        public void Pass(string message)
        {
            test.Pass(message);
            Status = test.Status;


        }
        public void Fail(Exception exception)
        {
            Status = Status.Fail;
            LogInfo(Status, exception.ToString());
            test.Fail(exception.ToString());

            
        }
        public void EndReport()
        {
            extent.Flush();
        }
        public ExtentReports Report
        {
            get
            {
                return extent;
            }
        }
        public Status Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
    }
}
