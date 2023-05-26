using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace LambdaExpressionUserProblem
{
    internal class UserValidationTests
    {
        public void HappyTestCases()
        {
            // Use case 1: Valid First Name
            bool isFirstNameValid = UserValidation.ValidateFirstName("John");
            Assert.IsTrue(isFirstNameValid);

            // Use case 2: Valid Last Name
            bool isLastNameValid = UserValidation.ValidateLastName("Doe");
            Assert.IsTrue(isLastNameValid);

            // Use case 3: Valid Email
            bool isEmailValid = UserValidation.ValidateEmail("john.doe@example.com");
            Assert.IsTrue(isEmailValid);

            // Use case 4: Valid Mobile Number
            bool isMobileNumberValid = UserValidation.ValidateMobileNumber("91 9919819801");
            Assert.IsTrue(isMobileNumberValid);

            // Use case 5: Valid Password
            bool isPasswordValid = UserValidation.ValidatePassword("Abcd1234!");
            Assert.IsTrue(isPasswordValid);
        }
        public void SadTestCases()
        {
            // Use case 1: Invalid First Name (less than 3 characters)
            bool isFirstNameValid = UserValidation.ValidateFirstName("Jo");
            Assert.IsFalse(isFirstNameValid);

            // Use case 2: Invalid Last Name (less than 3 characters)
            bool isLastNameValid = UserValidation.ValidateLastName("Do");
            Assert.IsFalse(isLastNameValid);

            // Use case 3: Invalid Email (missing @ symbol)
            bool isEmailValid = UserValidation.ValidateEmail("johndoeexample.com");
            Assert.IsFalse(isEmailValid);

            // Use case 4: Invalid Mobile Number (incorrect format)
            bool isMobileNumberValid = UserValidation.ValidateMobileNumber("9919819801");
            Assert.IsFalse(isMobileNumberValid);

            // Use case 5: Invalid Password (less than 8 characters)
            bool isPasswordValid = UserValidation.ValidatePassword("abcd123");
            Assert.IsFalse(isPasswordValid);
        }
        public void EmailParameterizedTest(string email, bool expectedResult)
        {
            bool isEmailValid = UserValidation.ValidateEmail(email);
            Assert.AreEqual(expectedResult, isEmailValid);
        }

        private static IEnumerable<TestCaseData> EmailTestCases()
        {
            yield return new TestCaseData("john.doe@example.com", true);
            yield return new TestCaseData("jane.smith@example.com", true);
            yield return new TestCaseData("john.doe@example", false); // Invalid email without top-level domain
            yield return new TestCaseData("jane.smith@example..com", false); // Invalid email with consecutive dots
            yield return new TestCaseData("john.doe@.com", false); // Invalid email with missing domain name
            yield return new TestCaseData("jane.smith@example.com.", false); // Invalid email with trailing dot
        }
        public void InvalidFirstNameTest()
        {
            Assert.Throws<InvalidFirstNameException>(() => UserValidation.ValidateFirstName("ab"));
        }
        public void InvalidLastNameTest()
        {
            Assert.Throws<InvalidLastNameException>(() => UserValidation.ValidateLastName("cd"));
        }

        [Test]
        public void InvalidEmailTest()
        {
            Assert.Throws<InvalidEmailException>(() => UserValidation.ValidateEmail("invalidemail"));
        }
        public void InvalidMobileNumberTest()
        {
            Assert.Throws<InvalidMobileNumberException>(() => UserValidation.ValidateMobileNumber("1234567890"));
        }

        [Test]
        public void InvalidPasswordTest()
        {
            Assert.Throws<InvalidPasswordException>(() => UserValidation.ValidatePassword("password"));
        }


    }
}
