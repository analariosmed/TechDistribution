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
    public class MyValidator
    {

        public MyValidator() { }
        
        public static bool IsValidID(string id)
        {
            if (!Regex.IsMatch(id, @"^\d{5}$"))
                return false;
            return true;
        }

        public static bool IsValidNumber(string id)
        {
            if (!Regex.IsMatch(id, @"^[1-9]\d{2,}$"))
                return false;
            return true;
        }
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            if (!Regex.IsMatch(phoneNumber, @"^\(\d{3}\)\d{3}-\d{4}$"))
                return false;
            return true;
        }
        public static bool IsValidText(string text)
        {
            if (text.Length == 0)
                return false;
            else
                if (!Regex.IsMatch(text, @"^[A-Za-z]+$"))
                return false;
            return true;
        }
        public static bool IsValidEmail(string email)
        {
            if (!Regex.IsMatch(email, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
                return false;
            return true;
        }
        public static bool IsValidPassword(string password)
        { 
            if (!Regex.IsMatch(password, @"^.{6,}$"))
                return false;
            return true;
        }
        
        public static bool IsValidISBN(string isbn)
        {
            if (!Regex.IsMatch(isbn, @"\b(?:ISBN(?:-1[03])?:? *)?((?:97[89])?\d{9}[\dx])\b"))
                return false;
            return true;
        }
        
        public static bool IsValidPrice(string price)
        {
            if (!Regex.IsMatch(price, @"\\d+(?:\\.\\d{2})?"))
                return false;
            return true;
        }

        public static bool IsValidYear(string year)
        {
            if (!Regex.IsMatch(year, @"\b\d{4}\b"))
                return false;
            return true;
        }

        public static bool IsValidTitle(string title)
        {
            if (title.Length == 0)
                return false;
            else if (!Regex.IsMatch(title, @"^[A-Za-z0-9]+$"))
                return false;

            return true;
        }

        public static bool IsValidName(string name)
        {
            if (!Regex.IsMatch(name, @"^[A-Za-z]+(?: [A-Za-z]\.?)*$"))
                return false;
            return true;
        }
    }
}
