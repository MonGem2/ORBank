using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace ORBank
{
    class Worker : User
    {
        static string Login_Input(string Pattern)
        {
            string NewLogin = string.Empty;
            Regex reg = new Regex(Pattern);
            while (!reg.IsMatch(NewLogin))
            {
                Console.Clear();
                Main_Menu.Print_Logotype_Fast();
                Console.WriteLine(SetCursorToCenter("Input your new login(letters and numbers):"));

                NewLogin = Console.ReadLine();
                if (NewLogin[0] == 'a' && NewLogin[1] == 'd' && NewLogin[2] == 'm' && NewLogin[3] == '\\')
                {
                    break;
                }
            }
            return NewLogin;
        }

        static string Password_Input(string Pattern,string NewLogin)
        {
            string NewPassword = string.Empty;
            Regex reg = new Regex(Pattern);
            while (!reg.IsMatch(NewPassword))
            {
                Console.Clear();
                Main_Menu.Print_Logotype_Fast();
                Console.WriteLine(SetCursorToCenter("Input your new login(letters and numbers):\n") + NewLogin);
                Console.WriteLine(SetCursorToCenter("Input your new Password(letters and numbers)(space bar is automatically deleted):"));

                char keych = ' ';

                NewPassword = string.Empty;
                while (keych != (char)ConsoleKey.Enter)
                {
                    keych = Console.ReadKey(true).KeyChar;
                    if (!Char.IsControl(keych) && keych != (char)ConsoleKey.Spacebar)
                    {
                        NewPassword += keych;
                        Console.Write('*');
                    }
                    else if (keych == (char)ConsoleKey.Backspace && Console.CursorLeft > 0 && NewPassword.Length != 0)
                    {
                        NewPassword = NewPassword.Remove(NewPassword.Length - 1);
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        Console.Write(" ");
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    }
                }



            }
            return NewPassword;
        }

        static string Name_Input(string Pattern)
        {
            string NewName = string.Empty;
            Regex reg = new Regex(Pattern);
            while (!reg.IsMatch(NewName))
            {
                Console.Clear();
                Main_Menu.Print_Logotype_Fast();
                Console.WriteLine(SetCursorToCenter("Input your real name(Capital letter):"));

                NewName = Console.ReadLine();
            }
            return NewName;
        }

        static string Surname_Input(string Pattern,string NewName)
        {
            string NewSurname = string.Empty;
            Regex reg = new Regex(Pattern);
            while (!reg.IsMatch(NewSurname))
            {
                Console.Clear();
                Main_Menu.Print_Logotype_Fast();
                Console.WriteLine(SetCursorToCenter("Input your real name(Capital letter):\n" + NewName));
                Console.WriteLine(SetCursorToCenter("Input your real surname(Capital letter):"));
                NewSurname = Console.ReadLine();
            }
            return NewSurname;
        }

        static string Phone_Input(string Pattern, string NewName, string NewSurname)
        {
            string NewPhone = "Number";
            Regex reg = new Regex(Pattern);
            while (!reg.IsMatch(NewPhone))
            {
                Console.Clear();
                Main_Menu.Print_Logotype_Fast();
                Console.WriteLine(SetCursorToCenter("Input your real name(Capital letter):\n" + NewName));
                Console.WriteLine(SetCursorToCenter("Input your real surname(Capital letter):\n" + NewSurname));
                Console.WriteLine(SetCursorToCenter("Input your Phone Number(+*******):"));
                NewPhone = Console.ReadLine();
            }
            return NewPhone;
        }

        static string Card_Number_Generator()
        {
            int card_num_size = 16;
            Random rand = new Random();
            string New_Card_Number = "";
            for (var i = 0; i < card_num_size; i++)
            {
                New_Card_Number += rand.Next(9).ToString();
            }
            return New_Card_Number;
        }

        static string PIN_Generator()
        {
            string NewPIN = string.Empty;
            Random rand = new Random();
            Console.Clear();
            Main_Menu.Print_Logotype_Fast();
            for (int i = 0; i < 4; i++)
            {
                NewPIN += rand.Next(9).ToString();
            }
            Console.WriteLine(SetCursorToCenter("Your new PIN:"));
            Console.WriteLine(SetCursorToCenter(NewPIN));
            return NewPIN;
            
        }


        public static User CreateUser()
        {
            string NewName;
            string NewSurname;
            string NewPhone;
            string NewLogin;
            string NewPassword;
            string NewPIN;
            string New_Card_Number;

            string LogPattern = @"^[A-Za-z]\w{5,15}$";
            string NamePattern = @"^[A-Z][a-z]{1,15}$";
            string PhonePattern = @"^([+][0-9\s-\(\)]{6,25})*$";


            NewLogin = Login_Input(LogPattern);

            if (File.Exists(@"files\users\" + NewLogin + ".ob"))
            {
                Console.WriteLine(SetCursorToCenter("This user has already been created"));
                Console.ReadKey(true);
                return null;
            }

            NewPassword = Password_Input(LogPattern, NewLogin);

            NewName = Name_Input(NamePattern);

            NewSurname = Surname_Input(NamePattern, NewName);

            NewPhone = Phone_Input(PhonePattern, NewName, NewSurname);

            New_Card_Number = Card_Number_Generator();

            NewPIN = PIN_Generator();

            Console.ReadKey(true);

            try
            {
                Console.WriteLine(SetCursorToCenter("User added"));
                User user = new User(NewName, NewSurname, NewPhone, NewPassword, NewLogin, NewPIN,New_Card_Number);
                return user;
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                return null;
            }

        }
    }
}
