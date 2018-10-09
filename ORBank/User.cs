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
    class User
    {
        public string Name { get; set; }

        public string SurName { get; set; }

        public Wallet wallet { get; set; }

        private string LogIn { get; set; }

        private string Password { get; set; }

        public string CardNum { get; }

        private string PINcode { get; set; }

        public string Phone_Number { get; set; }

        internal Wallet Money_1 { get; set; }

        public User()
        {
            
        }

        public void Save()
        {
            using (FileStream fileStream = new FileStream($@"files\users\{LogIn}.ob", FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, this);
            }

        }

        public User(string NewName, string NewSurname, string NewPhone, string NewPassword, string NewLogin, string NewPIN)
        {
            Name = NewName;
            SurName = NewSurname;
            Phone_Number = NewPhone;
            Password = NewPassword;
            LogIn = NewLogin;
            PINcode = NewPIN;
            wallet = new Wallet(1000);
            Save();
        }

            public bool IsPassTrue(string Pass)
        {
            if (Password == Pass)
                return true;
            return false;
        }

        public delegate string Cursor(string x);
        public static Cursor SetCursorToCenter = (x) => { Console.SetCursorPosition((Console.WindowWidth - x.Length) / 2, Console.CursorTop); return x; };

        public static bool Login(User ThisUser)
        {
            
            while (true)
            {
                Console.Clear();
                Cursor SetCursor = (x) => { Console.SetCursorPosition((Console.WindowWidth - x.Length) / 2, Console.CursorTop); return x; };
                Main_Menu.Print_Logotype_Fast();
                Console.WriteLine(SetCursor("Enter your login:"));
                string tempLogin = Console.ReadLine() + ".ob";
                string tempPass;
                Console.WriteLine(SetCursorToCenter("Input your Password(space bar is automatically deleted):"));

                char keych = ' ';

                tempPass = string.Empty;
                while (keych != (char)ConsoleKey.Enter)
                {
                    keych = Console.ReadKey(true).KeyChar;
                    if (!Char.IsControl(keych) && keych != (char)ConsoleKey.Spacebar)
                    {
                        tempPass += keych;
                        Console.Write('*');
                    }
                    else if (keych == (char)ConsoleKey.Backspace && Console.CursorLeft > 0 && tempPass.Length != 0)
                    {
                        tempPass = tempPass.Remove(tempPass.Length - 1);
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        Console.Write(" ");
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    }
                }
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
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Uncorrect password");
                        Console.ReadKey();
                        return false;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("This account does not exist  :(");
                    Console.ReadKey();

                    return false;

                }
            }

        }
    };
}
