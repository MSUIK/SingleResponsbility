using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsbility
{
    public class AccountGenerator
    {
        public static void CrateAccount(Person user)
        {
            Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1)}{user.LastName}");
            
        }
    }
}
