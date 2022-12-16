using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19UserRegistrationSystem
{
    internal class UC_1ValidFirstName
    {
        public static string REGEX_VALIDFIRSTNAME = (@"^[A-Z]{1}[A-Za-z]{2,}?$");


        public bool validateUC_1ValidFirstName(string validfirstname)
        {
            return Regex.IsMatch(validfirstname, REGEX_VALIDFIRSTNAME);
        }
    }
}
