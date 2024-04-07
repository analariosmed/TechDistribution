using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TechDistribution.VALIDATION
{
    public class Validator
    {

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
    }
}
