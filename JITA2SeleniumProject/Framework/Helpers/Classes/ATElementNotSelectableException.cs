using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Framework.Helpers.Classes
{
    [Serializable]
    public class ATElementNotSelectableException : Exception
    {
        public ATElementNotSelectableException()
        {
        }

        public ATElementNotSelectableException(string message)
            : base(message)
        {
        }

        public ATElementNotSelectableException(string message, Exception inner)
            : base(message, inner)
        {
        }
        public ATElementNotSelectableException(SerializationInfo info, StreamingContext context) :base(info, context)
        {

        }
    }
}
