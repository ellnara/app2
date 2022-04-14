using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15.Exceptions
{
    class MedLimitException:Exception
    {
        public MedLimitException()
        {
            Console.WriteLine("Cannot create Pharmacy object without Medicine limit");
        }
        public MedLimitException(string message)
         : base(message)
        {

        }
    }
}
