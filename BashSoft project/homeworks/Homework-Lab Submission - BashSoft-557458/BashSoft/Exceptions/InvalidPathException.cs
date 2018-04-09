﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft.Exceptions
{
    class InvalidPathException : Exception
    {
        private const string InvalidPath = "The source does not exist.";

        public InvalidPathException() : base(InvalidPath)
        {

        }
        public InvalidPathException(string message) : base(message)
        {

        }

    }
}
