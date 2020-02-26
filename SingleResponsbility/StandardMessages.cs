using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsbility
{
    public class StandardMessages
    {
        public static void WellcomeMessage()
        {
            Console.WriteLine("Welcome to my Application!");

        }

        public static void EndApplication()
        {
            Console.WriteLine("Press Enter to Colse......");
            Console.ReadLine();
        }
        public static void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"You did not give us a valid {fieldName}!");
         }
    }
}
