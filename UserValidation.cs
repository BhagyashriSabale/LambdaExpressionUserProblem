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
            if (!IsValidInput(firstName, name => name.Length >= 3 && char.IsUpper(name[0])))
            {
                throw new InvalidFirstNameException("Invalid First Name");
            }
            return true;
        }
        public static bool ValidateLastName(string lastName)
        {
            if (!IsValidInput(lastName, name => name.Length >= 3 && char.IsUpper(name[0])))
            {
                throw new InvalidLastNameException("Invalid Last Name");
            }
            return true;
        }

        public static bool ValidateEmail(string email)
        {
            if (!IsValidInput(email, ValidateEmailFormat))
            {
                throw new InvalidEmailException("Invalid Email");
            }
            return true;
        }
        public static bool ValidatePassword(string password)
        {
            if (!IsValidInput(password, ValidatePasswordFormat))
            {
                throw new InvalidPasswordException("Invalid Password");
            }
            return true;
        }
        public static bool ValidateMobileNumber(string mobileNumber)
        {
            if (!IsValidInput(mobileNumber, ValidateMobileNumberFormat))
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
        private static bool IsValidInput(string input, Func<string, bool> validationFunc)
        {
            return validationFunc.Invoke(input);
        }

        private static bool ValidateEmailFormat(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9]+([._+-][a-zA-Z0-9]+)*@[a-zA-Z0-9-]+(\.[a-zA-Z]{2,})*(\.[a-zA-Z]{2,6})$");
        }
        private static bool ValidateMobileNumberFormat(string mobileNumber)
        {
            return Regex.IsMatch(mobileNumber, @"^91 [1-9]\d{9}$");
        }

        private static bool ValidatePasswordFormat(string password)
        {
            return password.Length >= 8 && Regex.IsMatch(password, @"[A-Z]") &&
                Regex.IsMatch(password, @"\d") && Regex.IsMatch(password, @"[!@#$%^&*(),.?""':{}|<>]");
        }

    }
}
