using System;

namespace SingleResponsbility
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WellcomeMessage();

            Person user = PersonDataCapture.Capture();

            bool isUserValid = PersonValidator.Validate(user);
            if(isUserValid==false)
            {
                StandardMessages.EndApplication();
                return;
            }

            AccountGenerator.CrateAccount(user);
            StandardMessages.EndApplication();
        }
    }
}
