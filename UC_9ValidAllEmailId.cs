using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19UserRegistrationSystem
{
    internal class UC_9ValidAllEmailId
    {
        public static string REGEX_VALIDEMAIL = "^[a-zA-Z0-9]+([._+-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2,})?$";


        public bool validateValidAllEmail(string validemail)
        {
            return Regex.IsMatch(validemail, REGEX_VALIDEMAIL);
        }
    }
}
