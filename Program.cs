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
            Console.WriteLine("First Name is " + (isFirstNameValid ? "valid" : "invalid"));//UC1

            Console.Write("Enter a valid Last Name: ");
            string lastName = Console.ReadLine();
            bool isLastNameValid = UserValidation.ValidateLastName(lastName);
            Console.WriteLine("Last Name is " + (isLastNameValid ? "valid" : "invalid"));//UC2

            Console.Write("Enter a valid Email: ");
            string email = Console.ReadLine();
            bool isEmailValid = UserValidation.ValidateEmail(email);
            Console.WriteLine("Email is " + (isEmailValid ? "valid" : "invalid"));//UC3

            Console.Write("Enter a valid Password: ");
            string password = Console.ReadLine();
            bool isPasswordValid = UserValidation.ValidatePassword(password);
            Console.WriteLine("Password is " + (isPasswordValid ? "valid" : "invalid"));//UC4

            Console.Write("Enter a valid Mobile Number: ");
            string mobileNumber = Console.ReadLine();
            bool isMobileNumberValid = UserValidation.ValidateMobileNumber(mobileNumber);
            Console.WriteLine("Mobile Number is " + (isMobileNumberValid ? "valid" : "invalid"));//UC5

            Console.WriteLine("Enter a text containing email samples:");
            string text = Console.ReadLine();
            UserValidation.ClearEmailSamples(text);//UC6

            Console.WriteLine("Running JUnit tests...");
            UserValidationTests validationTests = new UserValidationTests();
            validationTests.HappyTestCases();
            validationTests.SadTestCases();
            validationTests.EmailParameterizedTest("john.doe@example.com", true);

            Console.WriteLine("Running custom exception tests...");
            UserValidationTests validationTests1 = new UserValidationTests();
            validationTests1.InvalidFirstNameTest();
            validationTests1.InvalidLastNameTest();
            validationTests1.InvalidEmailTest();
            validationTests1.InvalidMobileNumberTest();
            validationTests1.InvalidPasswordTest();
        }
    }
}