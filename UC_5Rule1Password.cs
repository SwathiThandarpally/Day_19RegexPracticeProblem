using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19UserRegistrationSystem
{
    internal class UC_5Rule1Password
    {
        public static string REGEX_PASSWORD = "^[A-Z]{1}[a-z]{7}$";//("^[A-Za-z0-9]{8,16}$");

        public bool validatePassWord(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD);
        }
    }
}
