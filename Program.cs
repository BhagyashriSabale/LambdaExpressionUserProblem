using System;
using System.Text.RegularExpressions;

namespace LambdaExpressionUserProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Lambda Expression Problem");
            Console.Write("Enter a valid First Name: ");
            string firstName = Console.ReadLine();
            bool isFirstNameValid = UserValidation.ValidateFirstName(firstName);
            Console.WriteLine("First Name is " + (isFirstNameValid ? "valid" : "invalid"));
            Console.Write("Enter a valid Last Name: ");
            string lastName = Console.ReadLine();
            bool isLastNameValid = UserValidation.ValidateLastName(lastName);
            Console.WriteLine("Last Name is " + (isLastNameValid ? "valid" : "invalid"));

            Console.Write("Enter a valid Email: ");
            string email = Console.ReadLine();
            bool isEmailValid = UserValidation.ValidateEmail(email);
            Console.WriteLine("Email is " + (isEmailValid ? "valid" : "invalid"));
            Console.Write("Enter a valid Password: ");
            string password = Console.ReadLine();
            bool isPasswordValid = UserValidation.ValidatePassword(password);
            Console.WriteLine("Password is " + (isPasswordValid ? "valid" : "invalid"));
        }
    }
}