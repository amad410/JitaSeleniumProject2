using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Helpers.Classes
{
    /// <summary>
    ///  This class is designed to store exceptions into a list. 
    ///  You can then retrieve all the exceptions through a static property.
    /// </summary>
    public static class ExceptionList
    {
        static List<Exception> exceptionList = new List<Exception>();
        //static List<string> exceptionList = new List<string>();
        public static void Add(Exception exception)
        {
            exceptionList.Add(exception);
        }

        public static List<Exception> Exceptions
        {
            get
            {
                return exceptionList;
            }
        }

    }
}
