using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Framework.Helpers.Classes
{
    [Serializable]
    public class ATWebDriverException : Exception
    {
        public ATWebDriverException()
        {
        }

        public ATWebDriverException(string message)
            : base(message)
        {
        }

        public ATWebDriverException(string message, Exception inner)
            : base(message, inner)
        {
        }
        public ATWebDriverException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
