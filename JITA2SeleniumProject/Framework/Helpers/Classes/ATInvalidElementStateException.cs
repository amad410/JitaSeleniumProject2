using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Framework.Helpers.Classes
{
    [Serializable]
    public class ATInvalidElementStateException : Exception
    {
        public ATInvalidElementStateException()
        {
        }

        public ATInvalidElementStateException(string message)
            : base(message)
        {
        }

        public ATInvalidElementStateException(string message, Exception inner)
            : base(message, inner)
        {
        }
        public ATInvalidElementStateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
