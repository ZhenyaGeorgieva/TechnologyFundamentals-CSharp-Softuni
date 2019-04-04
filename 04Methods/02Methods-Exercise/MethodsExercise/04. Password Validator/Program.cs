using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            CheckValidityOfPassword(password);
        }
        public static void CheckValidityOfPassword(string password)
        {
            bool isPassValid = true;
            int counterOfDigits = 0;
            bool isLengthValid = true;
            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isLengthValid = false;
            }

            for (int i = 0; i < password.Length; i++)
            {

                if (!((password[i] >= 65 && password[i] <= 90) || (password[i] >= 97 && password[i] <= 122) || (password[i] >= 48 && password[i] <= 57)))
                {
                    isPassValid = false;

                }
                if (password[i] >= 48 && password[i] <= 57)
                {
                    counterOfDigits += 1;
                }
            }
            if (!isPassValid)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (counterOfDigits < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (counterOfDigits >= 2 && isPassValid && isLengthValid)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}

