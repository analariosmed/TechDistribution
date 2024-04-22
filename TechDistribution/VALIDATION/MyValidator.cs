using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TechDistribution.BLL;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TechDistribution.VALIDATION
{
    /// <summary>
    /// Provides validation methods using regular expressions.
    /// </summary>
    public class MyValidator
    {
        public MyValidator() { }

        /// <summary>
        /// Validates an ID consisting of 5 digits.
        /// </summary>
        public static bool IsValidID(string id)
        {
            // Example: "12345" is a valid ID.
            return Regex.IsMatch(id, @"^\d{5}$");
        }

        /// <summary>
        /// Validates a number with at least 3 digits.
        /// </summary>
        public static bool IsValidNumber(string number)
        {
            // Example: "123" is a valid number.
            return Regex.IsMatch(number, @"^[1-9]\d{2,}$");
        }

        /// <summary>
        /// Validates a phone number in the format (XXX)XXX-XXXX.
        /// </summary>
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            // Example: "(123)456-7890" is a valid phone number.
            return Regex.IsMatch(phoneNumber, @"^\(\d{3}\)\d{3}-\d{4}$");
        }

        /// <summary>
        /// Validates text containing only alphabetic characters.
        /// </summary>
        public static bool IsValidText(string text)
        {
            // Example: "HelloWorld" is a valid text.
            return Regex.IsMatch(text, @"^[A-Za-z]+$");
        }

        /// <summary>
        /// Validates an email address.
        /// </summary>
        public static bool IsValidEmail(string email)
        {
            // Example: "example@email.com" is a valid email address.
            return Regex.IsMatch(email, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
        }

        /// <summary>
        /// Validates a password with at least 6 characters.
        /// </summary>
        public static bool IsValidPassword(string password)
        {
            // Example: "Pass1234" is a valid password.
            return Regex.IsMatch(password, @"^.{6,}$");
        }

        /// <summary>
        /// Validates an ISBN number.
        /// </summary>
        public static bool IsValidISBN(string isbn)
        {
            // Example: "ISBN-1234567890" is a valid ISBN number.
            return Regex.IsMatch(isbn, @"\b(?:ISBN(?:-1[03])?:? *)?((?:97[89])?\d{9}[\dx])\b");
        }

        /// <summary>
        /// Validates a price with optional decimal places.
        /// </summary>
        public static bool IsValidPrice(string price)
        {
            // Example: "10.99" is a valid price.
            return Regex.IsMatch(price, @"\d+(?:\.\d{2})?");
        }

        /// <summary>
        /// Validates a year in 4-digit format.
        /// </summary>
        public static bool IsValidYear(string year)
        {
            // Example: "2024" is a valid year.
            return Regex.IsMatch(year, @"\b\d{4}\b");
        }

        /// <summary>
        /// Validates a title containing alphanumeric characters.
        /// </summary>
        public static bool IsValidTitle(string title)
        {
            // Example: "Book123" is a valid title.
            return Regex.IsMatch(title, @"^[A-Za-z0-9]+$");
        }

        /// <summary>
        /// Validates a name with optional middle initials.
        /// </summary>
        public static bool IsValidName(string name)
        {
            // Example: "John D. Doe" is a valid name.
            return Regex.IsMatch(name, @"^[A-Za-z]+(?: [A-Za-z]\.?)*$");
        }
    }
}
