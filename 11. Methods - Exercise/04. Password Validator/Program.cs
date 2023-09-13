﻿namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPassword = Console.ReadLine();

            PasswordChecker(inputPassword);
        }

        static void PasswordChecker(string password)
        {
            bool sixToTenCharacters = false;
            bool onlyLettersAndDigits = false;
            bool atLeastTwoDigits = false;

            if (password.Length >= 6 && password.Length <= 10)
            {
                sixToTenCharacters = true;
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            char[] chars = password.ToCharArray();
            for (int i = 0; i < password.Length; i++)
            {
                if (chars[i] >= 65 && chars[i] <= 90 ||
                    chars[i] >= 97 && chars[i] <= 122 ||
                        chars[i] >= 48 && chars[i] <= 57)
                {
                    onlyLettersAndDigits = true;
                }
                else
                {
                    onlyLettersAndDigits = false;
                    Console.WriteLine("Password must consist only of letters and digits");
                    break;
                }
            }

            int twoDigits = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if (chars[i] >= 48 && chars[i] <= 57)
                {
                    twoDigits++;

                    if (twoDigits == 2)
                    {
                        atLeastTwoDigits = true;
                        break;
                    }
                }
            }
            if (atLeastTwoDigits == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (sixToTenCharacters == true && onlyLettersAndDigits == true && atLeastTwoDigits == true)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}