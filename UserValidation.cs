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
            return Regex.IsMatch(firstName, @"^[A-Z][a-zA-Z]{2,}$");
        }
        public static bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, @"^[A-Z][a-zA-Z]{2,}$");
        }
        public static bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9]+([._+-][a-zA-Z0-9]+)*@[a-zA-Z0-9-]+(\.[a-zA-Z]{2,})*(\.[a-zA-Z]{2,6})$");
        }
        public static bool ValidatePassword(string password)
        {
            if (password.Length < 8)
                return false;

            if (!Regex.IsMatch(password, @"[A-Z]"))
                return false;

            if (!Regex.IsMatch(password, @"\d"))
                return false;

            if (!Regex.IsMatch(password, @"[!@#$%^&*(),.?""':{}|<>]"))
                return false;

            return true;
        }
        public static bool ValidateMobileNumber(string mobileNumber)
        {
            return Regex.IsMatch(mobileNumber, @"^91 [1-9]\d{9}$");
        }
    }
}
