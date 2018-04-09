using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft.Exceptions
{
    class InvalidMarkOnCourseException : Exception
    {
        public const string InvalidMark = "The given mark is invalid";

        public InvalidMarkOnCourseException(string message) : base(message)
        {

        }

        public InvalidMarkOnCourseException() : base(InvalidMark)
        {

        }
    }
}
