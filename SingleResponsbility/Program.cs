using System;

namespace SingleResponsbility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Application!");
            //Ask for User information

            Person user = new Person();
            
            Console.Write("Wht is your first name");
            user.FirstName = Console.ReadLine();

            Console.Write("What is your Last name");
            user.LastName = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(user.FirstName))
            {
                Console.WriteLine("You did not give us a valid first name");
                Console.ReadLine();
                return;
            }
            if(string.IsNullOrWhiteSpace(user.LastName))
            {
                Console.WriteLine("You did not give us a valid last name");
                Console.ReadLine();
                return;
            }

            //Create a username for the pweerson
            Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1)}{user.LastName}");
            Console.ReadLine();

        }
    }
}
