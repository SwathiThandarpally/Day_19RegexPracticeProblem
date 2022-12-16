using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19UserRegistrationSystem
{
    internal class UC_8Rule4Password
    {
        public static string REGEX_SPECIALCHARACTER = ("^[A-Za-z]{6,}[A-Z]{1,}[0-9]{1,}[-~!@#$%^*()_+{}:|?`;',]{1,}$");


        public bool validateSpecialCharacter(string password4)
        {
            return Regex.IsMatch(password4, REGEX_SPECIALCHARACTER);
        }
    }
}
