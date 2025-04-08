using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlhamdApplication
{
    internal class Validation
    {
        public static bool IsValidPassword(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 5)
            {
                return false;
            }

            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c)) return false;
            }

            return true;
        }

        public static bool IsValidName(string name)
        {
            string pattern = @"^[\p{L}\s]+$";

            return Regex.IsMatch(name, pattern);
        }

        public static bool IsValidPhone(string phone)
        {
            string pattern = @"^0\d{10}$";

            return Regex.IsMatch(phone, pattern);
        }
    }
}
