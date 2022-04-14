using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15.Exceptions
{
    class CapacityLimitException:Exception
    {
        public CapacityLimitException()
        {
            Console.WriteLine("Capacity is full");
        }
        public CapacityLimitException(string message)
         : base(message)
        {

        }
    }
}
