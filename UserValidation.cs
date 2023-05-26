using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LambdaExpressionUserProblem
{
    internal class UserValidation
    {
        public static bool ValidateFirstName(string firstName)
        {
            if (!Regex.IsMatch(firstName, @"^[A-Z][a-zA-Z]{2,}$"))
            {
                throw new InvalidFirstNameException("Invalid First Name");
            }
            return true;
        }
        public static bool ValidateLastName(string lastName)
        {
            if (!Regex.IsMatch(lastName, @"^[A-Z][a-zA-Z]{2,}$"))
            {
                throw new InvalidLastNameException("Invalid Last Name");
            }
            return true;
        }
        public static bool ValidateEmail(string email)
        {
            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9]+([._+-][a-zA-Z0-9]+)*@[a-zA-Z0-9-]+(\.[a-zA-Z]{2,})*(\.[a-zA-Z]{2,6})$"))
            {
                throw new InvalidEmailException("Invalid Email");
            }
            return true;
        }
        public static bool ValidatePassword(string password)
        {
            if (password.Length < 8)
            {
                throw new InvalidPasswordException("Invalid Password");
            }
            return true;

            if (!Regex.IsMatch(password, @"[A-Z]"))
            {
                throw new InvalidPasswordException("Invalid Password");
            }
            return true;

            if (!Regex.IsMatch(password, @"\d"))
            {
                throw new InvalidPasswordException("Invalid Password");
            }
            return true;

            if (!Regex.IsMatch(password, @"[!@#$%^&*(),.?""':{}|<>]"))
            {
                throw new InvalidPasswordException("Invalid Password");
            }
            return true;
        }
        public static bool ValidateMobileNumber(string mobileNumber)
        {
            if (!Regex.IsMatch(mobileNumber, @"^91 [1-9]\d{9}$"))
            {
                throw new InvalidMobileNumberException("Invalid Mobile Number");
            }
            return true;
        }

        public static void ClearEmailSamples(string text)
        {
            string cleanedText = Regex.Replace(text, @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b", "");
            Console.WriteLine(cleanedText);
        }
        
    }
}
