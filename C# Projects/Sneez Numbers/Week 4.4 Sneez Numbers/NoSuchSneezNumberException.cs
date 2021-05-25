using System;
using System.Runtime.Serialization;

namespace Week_4._4_Sneez_Numbers
{
   
    public  class NoSuchSneezNumberException : Exception
    {
        public NoSuchSneezNumberException()
        {
        }

        public NoSuchSneezNumberException(string message) : base(message)
        {
        }

        public NoSuchSneezNumberException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoSuchSneezNumberException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}