using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19UserRegistrationSystem
{
    internal class UC_2ValidLastName
    {
        public static string REGEX_VALIDLASTNAME = (@"^[A-Z]{1}[A-Za-z]{2,}?$");


        public bool validateUC_2ValidLastName(string validlastname)
        {
            return Regex.IsMatch(validlastname, REGEX_VALIDLASTNAME);
        }
    }
}
