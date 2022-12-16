using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19UserRegistrationSystem
{
    internal class UC_6Rule2Password
    {
        public static string REGEX_PASSWORD = ("^[A-Z]{1,8}[a-z0-9]{7,}$");


        public bool validatePassWord(string password2)
        {
            return Regex.IsMatch(password2, REGEX_PASSWORD);
        }
    }
}
