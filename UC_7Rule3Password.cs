using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19UserRegistrationSystem
{
    internal class UC_7Rule3Password
    {
        public static string REGEX_PASSWORD = ("^[A-Za-z]{6,}[A-Z]{1,}[0-9]{1,}$");


        public bool validatePassWord(string password3)
        {
            return Regex.IsMatch(password3, REGEX_PASSWORD);
        }
    }
}
