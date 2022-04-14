using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15.Exceptions
{
    public class NullReferenceExceptionn : Exception
    {
        public NullReferenceExceptionn()
        {
            Console.WriteLine("ref cannot be null");
        }

        public NullReferenceExceptionn(string message)
            : base(message)
        {
            
        }

    }
}
