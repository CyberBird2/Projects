using System;
using System.Runtime.Serialization;

namespace Week_4._2_Marks_Analyzer
{
    [Serializable]
    public class MarkOutOfRangeException : Exception
    {
        public MarkOutOfRangeException()
        {
        }

        public MarkOutOfRangeException(string message) : base(message)
        {


        }

        public MarkOutOfRangeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MarkOutOfRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}