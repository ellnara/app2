﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException()
        {
            Console.WriteLine("Medicine not found");
        }
        public NotFoundException(string message)
          : base(message)
        {

        }
    }
}
