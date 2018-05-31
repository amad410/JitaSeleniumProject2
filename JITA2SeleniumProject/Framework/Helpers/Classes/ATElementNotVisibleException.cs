using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Framework.Helpers.Classes
{
    [Serializable]
    public class ATElementNotVisibleException : Exception
    {
        public ATElementNotVisibleException()
        {
        }

        public ATElementNotVisibleException(string message)
            : base(message)
        {
        }

        public ATElementNotVisibleException(string message, Exception inner)
            : base(message, inner)
        {
        }
        public ATElementNotVisibleException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
