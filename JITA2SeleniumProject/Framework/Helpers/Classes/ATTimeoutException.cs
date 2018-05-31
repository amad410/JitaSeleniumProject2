using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Framework.Helpers.Classes
{
    [Serializable]
    public class ATTimeoutException : Exception
    {
        public ATTimeoutException()
        {
        }

        public ATTimeoutException(string message)
            : base(message)
        {
        }

        public ATTimeoutException(string message, Exception inner)
            : base(message, inner)
        {
        }
        public ATTimeoutException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
