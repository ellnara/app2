using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15.Exceptions
{
    public class MedicineAlreadyExistsException:Exception
    {
        public MedicineAlreadyExistsException()
        {
            Console.WriteLine("Medicine already exists");
        }
        public MedicineAlreadyExistsException(string message)
         : base(message)
        {

        }
    }
}
