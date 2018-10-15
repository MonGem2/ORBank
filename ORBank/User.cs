using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Text.RegularExpressions;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ORBank
{
    [Serializable]
    class User : IUser
    {
        public string Name { get; set; }

        public string SurName { get; set; }

        public Wallet wallet { get; set; }

        public string LogIn { get; set; }

        public string Password { get; set; }

        public string CardNum { get; set; }

        public string PINcode { get; set; }

        public string Phone_Number { get; set; }

        public User()
        {
            
        }

        public static string Login_Input()
        {
            string Pattern = @"^[A-Za-z]\w{5,15}$";
            string NewLogin = string.Empty;
            Regex reg = new Regex(Pattern);
            while (!reg.IsMatch(NewLogin))
            {
                Console.Clear();
                Main_Menu.Print_Logotype_Fast();
                Console.WriteLine(SetCursorToCenter("Input your login:"));

                NewLogin = Console.ReadLine();
            }
            return NewLogin;
        }

        public static string Password_Input()
        {
            string Pattern = @"^[A-Za-z]\w{5,15}$";
            string NewPassword = string.Empty;
            Regex reg = new Regex(Pattern);
            while (!reg.IsMatch(NewPassword))
            {
                Console.Clear();
                Main_Menu.Print_Logotype_Fast();
                Console.WriteLine(SetCursorToCenter("Input your Password(space bar is automatically deleted):"));

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

        public static string PIN_Input()
        {
            string PIN;
            Console.Clear();
            Main_Menu.Print_Logotype_Fast();
            Console.WriteLine(SetCursorToCenter("Input your PIN:"));
            PIN = Console.ReadLine();
            return PIN;
        }

        public static string Phone_Input()
        {
            string Phone;
            Console.Clear();
            Main_Menu.Print_Logotype_Fast();
            Console.WriteLine(SetCursorToCenter("Input your phone:"));
            Phone = Console.ReadLine();
            return Phone;
        }

        public static string Surname_Input()
        {
            string Surname;
            Console.Clear();
            Main_Menu.Print_Logotype_Fast();
            Console.WriteLine(SetCursorToCenter("Input your surname:"));
            Surname = Console.ReadLine();
            return Surname;
        }

        public static string Name_Input()
        {
            string Name;
            Console.Clear();
            Main_Menu.Print_Logotype_Fast();
            Console.WriteLine(SetCursorToCenter("Input your name:"));
            Name = Console.ReadLine();
            return Name;
        }

        public bool IsPINCorrect(string PIN)
        {
            if (PIN == PINcode)
            {
                return true;
            }
            return false;
        }

        public void Save()
        {
            using (FileStream fileStream = new FileStream($@"files\users\{LogIn}.ob", FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, this);
            }

        }

        public User(string NewName, string NewSurname, string NewPhone, string NewPassword,
            string NewLogin, string NewPIN,string New_Card_Number)
        {
            if (!File.Exists(@"files\users\" + NewLogin))
            {
                Name = NewName;
                SurName = NewSurname;
                Phone_Number = NewPhone;
                Password = NewPassword;
                LogIn = NewLogin;
                PINcode = NewPIN;
                CardNum = New_Card_Number;
                wallet = new Wallet(0);
                Save();
            }
            else Console.WriteLine("This account has already been created");
            
        }

        public bool IsPassTrue(string Pass)
        {
            if (Password == Pass)
                return true;
            return false;
        }

        public delegate string Cursor(string x);
        public static Cursor SetCursorToCenter = (x) => { Console.SetCursorPosition((Console.WindowWidth - x.Length) / 2,
            Console.CursorTop); return x; };

        public static User SignIn()
        {
            
            while (true)
            {
                User ThisUser;
                Console.Clear();
                Cursor SetCursor = (x) => { Console.SetCursorPosition((Console.WindowWidth - x.Length) / 2, Console.CursorTop); return x; };
                Main_Menu.Print_Logotype_Fast();
                Console.WriteLine(SetCursor("Enter your login:"));
                string tempLogin = Console.ReadLine() + ".ob";
                string tempPass;
                Console.WriteLine(SetCursorToCenter("Input your Password(space bar is automatically deleted):"));

                tempPass = Password_Input();
                Console.Write(SetCursor("Loading"));
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(100);
                }
                Console.WriteLine();

                try
                {
                    FileStream fileStream = new FileStream($@"files\users\{tempLogin}", FileMode.Open, FileAccess.Read);
                    BinaryFormatter formatter = new BinaryFormatter();
                    User item = (User)formatter.Deserialize(fileStream);
                    fileStream.Close();
                    if (item.IsPassTrue(tempPass))
                    {
                        ThisUser = item;
                        Console.WriteLine("You authorized");
                        Console.ReadKey();
                        return item;
                    }
                    else
                    {
                        Console.WriteLine("Uncorrect password");
                        Console.ReadKey();
                        return null;
                    }
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("This account does not exist or blocked  :(");
                    Console.ReadKey();

                    return null;

                }
            }

        }

        private void ChangePass()
        {
            if (IsPassTrue(Password_Input()))
            {
                Password = Password_Input();
                Console.WriteLine(SetCursorToCenter("Password changed"));
                Save();
            }
            else Console.WriteLine("Incorrect password");
        }

        private void ChangePhone()
        {
            if (IsPassTrue(Password_Input()))
            {
                Phone_Number = Phone_Input();
                Console.WriteLine(SetCursorToCenter("Phone changed"));
                Save();
            }
            else Console.WriteLine("Incorrect password");
        }

        private void ChangeNameSurname()
        {
            if (IsPassTrue(Password_Input()))
            {
                SurName = Surname_Input();
                Name = Name_Input();
                Console.WriteLine(SetCursorToCenter("Name/Surname changed"));
                Save();
            }
            else Console.WriteLine("Incorrect password");
        }

        public void ViewProfile()
        {
            Console.Clear();
            Main_Menu.Print_Logotype_Fast();
            Console.WriteLine(SetCursorToCenter("Your name: " + Name));
            Console.WriteLine(SetCursorToCenter("Your surname: " + SurName));
            Console.WriteLine(SetCursorToCenter("Your phone: " + Phone_Number));
            Console.WriteLine(SetCursorToCenter("Your card number: " + CardNum));
            Console.WriteLine(SetCursorToCenter("Your cash: " + wallet.ToString()));
            Console.ReadKey(true);
        }

        public void ChangeProfile()
        {
            int variant_ = Main_Menu.Variant(new List<string> { "Change password", "Change phone", "Change name/surname",
                "Delete this account", "Back" });
            if (variant_ == 0)
            {
                ChangePass();
            }
            if (variant_ == 1)
            {
                ChangePhone();
            }
            if (variant_ == 2)
            {
                ChangeNameSurname();
            }
            if (variant_ == 3)
            {
                Console.WriteLine("Do you really want to delete this account?");
                if (Main_Menu.Variant(new List<string> { "Yes", "No" }) == 0)
                {
                    File.Delete(@"files\users\" + LogIn + ".ob");
                    Environment.Exit(0);
                }
            }
            if (variant_ == 4)
            {
                return;
            }
        }

        public Deposit CreateDeposit()
        {
            double sum_;
            while (true)
            {
                Console.WriteLine(SetCursorToCenter("Enter the deposit amount"));
                string sum = Console.ReadLine();
                try
                {
                    sum_ = Double.Parse(sum);
                    if (wallet.Get_Wallet() < (decimal)sum_)
                    {
                        Console.WriteLine("There is not enough money on the balance sheet");
                    }
                    break;
                    
                }
                catch
                {
                    Console.WriteLine("Incorrect input, try again");
                    Console.ReadKey(true);
                }
            }
            

            return new Deposit(sum_);
        }

        public void TakeDeposit(Deposit depos)
        {
            wallet = new Wallet(wallet.Moneys + (decimal)depos.Get_Sum());
        }
    }
}
