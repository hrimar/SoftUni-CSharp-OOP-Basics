using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft.Exceptions
{
    class InvalidStringException : Exception
    {
        public const string InvalidString = "The given string is invalid.";

        public InvalidStringException() : base(InvalidString)
        {

        }

        public InvalidStringException(string message) : base(message)
        {

        }
    }
}
