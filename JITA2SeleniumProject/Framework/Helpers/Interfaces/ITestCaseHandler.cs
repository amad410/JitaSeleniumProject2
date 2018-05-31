using Framework.Driver;
using Framework.Helpers.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Helpers.Interfaces
{
    public interface ITestCaseHandler
    {
        void Invoke(Action testStep, MyWebDriver driver, BasicReport report);
        void Invoke<T>(Action testCase, MyWebDriver driver, BasicReport report);


    }
}
