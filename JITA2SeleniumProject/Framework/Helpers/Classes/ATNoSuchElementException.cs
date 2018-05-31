using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Framework.Helpers.Classes
{
    [Serializable]
    public class ATNoSuchElementException : Exception
    {

        public ATNoSuchElementException()
        {
        }

        public ATNoSuchElementException(string message)
            : base(message)
        {
        }

        public ATNoSuchElementException(string message, Exception inner)
            : base(message, inner)
        {
            
        }
        public ATNoSuchElementException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
