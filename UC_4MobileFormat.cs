using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19UserRegistrationSystem
{
    internal class UC_4MobileFormat
    {
        public static string REGEX_VALIDPHONENUMBER = ("[1-9][0-9][ ]?[6-9][0-9]{9}$");

        public bool validateUC_3ValidPhoneNumber(string validemail)
        {
            return Regex.IsMatch(validemail, REGEX_VALIDPHONENUMBER);
        }
    }
}
