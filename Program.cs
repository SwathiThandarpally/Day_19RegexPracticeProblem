namespace Day19UserRegistrationSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            //UseCase1
            UC_1ValidFirstName validFirstName = new UC_1ValidFirstName();
            Console.WriteLine("please enter the name");

            string validfirstname = Console.ReadLine();

            bool value1 = validFirstName.validateUC_1ValidFirstName(validfirstname);
            if (value1)
            {
                Console.WriteLine("Name is matched");
            }
            else
            {
                Console.WriteLine("Name is not matched");
            }
            //UseCase2
            UC_2ValidLastName validLastName2 = new UC_2ValidLastName();
            Console.WriteLine("please enter the name");

            string validlastname = Console.ReadLine();

            bool value2 = validLastName2.validateUC_2ValidLastName(validlastname);
            if (value2)
            {
                Console.WriteLine("Name is matched");
            }
            else
            {
                Console.WriteLine("Name is not matched");
            }
            //UseCase3
            UC_3ValidEmail validEmail3 = new UC_3ValidEmail();
            Console.WriteLine("please enter the EmailId");

            string validemail = Console.ReadLine();

            bool value3 = validEmail3.validateUC_3ValidEmail(validemail);
            if (value3)
            {
                Console.WriteLine("Name is matched");
            }
            else
            {
                Console.WriteLine("Name is not matched");
            }
            //UseCase4
            UC_4MobileFormat mobileFormat = new UC_4MobileFormat();
            Console.WriteLine("please enter the phonenumber");

            string phonenumber = Console.ReadLine();

            bool value4 = mobileFormat.validateUC_3ValidPhoneNumber(phonenumber);
            if (value4)
            {
                Console.WriteLine("PhoneNumber is matched");
            }
            else
            {
                Console.WriteLine("PhoneNumber is not matched");
            }
            //UseCase5
            UC_5Rule1Password passWord = new UC_5Rule1Password();
            Console.WriteLine("please enter the password");

            string password = Console.ReadLine();

            bool value5 = passWord.validatePassWord(password);
            if (value5)
            {
                Console.WriteLine("password is matched");
            }
            else
            {
                Console.WriteLine("password is not matched");
            }
            //UseCase6
            UC_6Rule2Password password6Rule2 = new UC_6Rule2Password();
            Console.WriteLine("please enter the password");

            string password2 = Console.ReadLine();

            bool value6 = password6Rule2.validatePassWord(password);
            if (value6)
            {
                Console.WriteLine("password is matched");
            }
            else
            {
                Console.WriteLine("password is not matched");
            }
            //UseCase7
            UC_7Rule3Password password6Rule3 = new UC_7Rule3Password();
            Console.WriteLine("please enter the password");

            string password3 = Console.ReadLine();

            bool value7 = password6Rule3.validatePassWord(password);
            if (value7)
            {
                Console.WriteLine("password is matched");
            }
            else
            {
                Console.WriteLine("password is not matched");
            }
            //UseCase8
            UC_8Rule4Password passwordRule4 = new UC_8Rule4Password();
            Console.WriteLine("please enter the password");

            string password4 = Console.ReadLine();

            bool value8 = passwordRule4.validateSpecialCharacter(password);
            if (value8)
            {
                Console.WriteLine("password is matched");
            }
            else
            {
                Console.WriteLine("password is not matched");
            }
            //UseCase9
            UC_9ValidAllEmailId allEmailId = new UC_9ValidAllEmailId();
            Console.WriteLine("please enter the EmailId");

            string validAllemail = Console.ReadLine();

            bool value = allEmailId.validateValidAllEmail(validemail);
            if (value)
            {
                Console.WriteLine("Email is matched");
            }
            else
            {
                Console.WriteLine("Email is not matched");
            }
        }
    }
}