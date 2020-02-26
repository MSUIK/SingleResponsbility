using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsbility
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            Person output = new Person();

            Console.Write("Wht is your first name");
            output.FirstName = Console.ReadLine();

            Console.Write("What is your Last name");
            output.LastName = Console.ReadLine();

            return output;
        }
    }
}
