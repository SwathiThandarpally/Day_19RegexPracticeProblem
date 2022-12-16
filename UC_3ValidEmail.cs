using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19UserRegistrationSystem
{
    internal class UC_3ValidEmail
    {
        public static string REGEX_VALIDEMAIL = ("^[A-Za-z]{3,}([.][A-Za-z]{3,})?[@][A-Za-z]{2,}[.][A-Za-z]{2,}([.][A-Za-z]{2})?$");


        public bool validateUC_3ValidEmail(string validemail)
        {
            return Regex.IsMatch(validemail, REGEX_VALIDEMAIL);
        }
    }
}
