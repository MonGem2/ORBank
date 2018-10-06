using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ORBank
{
    class Worker : User
    {
        public static void CreateUser()
        {
            Random rand = new Random();

            string NewName = string.Empty;
            string NewSurname = string.Empty;
            string NewPhone = "Number";
            string NewLogin = string.Empty;
            string NewPassword = string.Empty;
            string NewPIN = string.Empty;
            string New_Card_Number = string.Empty;

            string LogPattern = @"^[A-Za-z]\w{5,15}$";
            string NamePattern = @"^[A-Z][a-z]{1,15}$";
            string PhonePattern = @"^([+][0-9\s-\(\)]{6,25})*$";
            string PINPattern = @"^\d{4}$";

            Regex reg = new Regex(LogPattern);

            while (!reg.IsMatch(NewLogin))
            {
                Console.Clear();
                //Main_Menu.Print_Logotype_Fast();
                Console.WriteLine(SetCursorToCenter("Input your new login:"));
                NewLogin = Console.ReadLine();
            }

            while (!reg.IsMatch(NewPassword))
            {
                Console.Clear();
                //Main_Menu.Print_Logotype_Fast();
                Console.WriteLine(SetCursorToCenter("Input your new login:\n") + NewLogin);
                Console.WriteLine(SetCursorToCenter("Input your new Password(F2-show password):"));

                char keych = ' ';
               
                NewPassword = string.Empty;
                while (keych != (char)13)
                {
                    keych = Console.ReadKey(true).KeyChar;
                    if (!Char.IsControl(keych)&&keych!=(char)ConsoleKey.Spacebar)
                    {
                        NewPassword += keych;
                        Console.Write('*');
                    }
                    else if (keych == (char)ConsoleKey.Backspace && Console.CursorLeft > 0&& NewPassword.Length!=0)
                    {
                        NewPassword=NewPassword.Remove(NewPassword.Length-1);
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        Console.Write(" ");
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    }
                }
                
                
                
            }

            reg = new Regex(NamePattern);
            while (!reg.IsMatch(NewName))
            {
                Console.Clear();
                //Main_Menu.Print_Logotype_Fast();
                Console.WriteLine(SetCursorToCenter("Input your real name:"));
                NewName = Console.ReadLine();
            }

            while (!reg.IsMatch(NewSurname))
            {
                Console.Clear();
                //Main_Menu.Print_Logotype_Fast();
                Console.WriteLine(SetCursorToCenter("Input your real name:\n" + NewName));
                Console.WriteLine(SetCursorToCenter("Input your real surname:"));
                NewSurname = Console.ReadLine();
            }

            reg = new Regex(PhonePattern);
            while (!reg.IsMatch(NewPhone))
            {
                Console.Clear();
                //Main_Menu.Print_Logotype_Fast();
                Console.WriteLine(SetCursorToCenter("Input your real name:\n" + NewName));
                Console.WriteLine(SetCursorToCenter("Input your real surname:\n" + NewSurname));
                Console.WriteLine(SetCursorToCenter("Input your Phone Number:"));
                NewPhone = Console.ReadLine();
            }

            for (var i = 0; i < 16; i++)
            {
                New_Card_Number += rand.Next(9).ToString();
            }

            reg = new Regex(PINPattern);
            while (!reg.IsMatch(NewPIN))
            {
                Console.Clear();
                //Main_Menu.Print_Logotype_Fast();
                Console.WriteLine(SetCursorToCenter("Your card number:\n") + SetCursorToCenter(New_Card_Number));
                Console.WriteLine(SetCursorToCenter("Your new PIN:"));
                for (int i = 0; i < 4; i++)
                {
                    NewPIN += rand.Next(9).ToString();
                }
                Console.WriteLine(SetCursorToCenter(NewPIN));
            }

            WorkWithFiles.FillingOrCreateFilling_Main_File(NewLogin, NewPassword, NewName, NewPhone, NewSurname,
                New_Card_Number, NewPIN);

        }
    }
}
