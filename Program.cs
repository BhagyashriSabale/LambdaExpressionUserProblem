using System.Text.RegularExpressions;

namespace LambdaExpressionUserProblem
{
    internal class Program
    {
        public static bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, @"^[A-Z][a-zA-Z]{2,}$");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Lambda Expression Problem");
            Console.Write("Enter a valid First Name: ");
            string firstName = Console.ReadLine();
            bool isFirstNameValid = ValidateFirstName(firstName);
            Console.WriteLine("First Name is " + (isFirstNameValid ? "valid" : "invalid"));
        }
    }
}