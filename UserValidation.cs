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
    }
}
