using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace ORBank
{
    class User
    {
        private string Name_;
        public string Name
        {
            get { return Name_; }
            set { Name_ = value; }
        }

        private string SurName_;
        public string SurName
        {
            get { return SurName_; }
            set { SurName_ = value; }
        }

        private Decimal Money_;
        public Decimal Wallet
        {
            get { return Money_+65; }
            set { Money_ = value-65; }
        }

        private string Login_;
        private string LogIn
        {
            get { return Login_; }
            set { Login_ = value; }
        }

        private string PassWord_;
        private string Password
        {
            get { return PassWord_; }
            set { PassWord_ = value; }
        }

        private int[] Card_Number_ = new int[16];
        public int[] CardNum
        {
            get { return Card_Number_; }
        }

        private string PIN_;
        private string PINcode
        {
            get { return PIN_; }
            set { PIN_ = value; }
        }

        private string Phone_Number_;
        public string Phone_Number
        {
            get { return Phone_Number_; }
            set { Phone_Number_ = value; }
        }


        public User()
        {

        }

        delegate string Cursor(string x);
        public void CreateUser()
        {
            Cursor SetCursor = (x) => { Console.SetCursorPosition((Console.WindowWidth - x.Length) / 2, Console.CursorTop); return x; }; 
            Random rand = new Random();
            string NewName = string.Empty;
            string NewSurname = string.Empty;
            string LogPattern = @"^[A-Za-z]{2,12}$";
            Regex reg = new Regex(LogPattern);
            while (!reg.IsMatch(NewName))
            {
                Main_Menu.Print_Logotype_Fast();
                Console.WriteLine(SetCursor("Input you real name:"));
                NewName = Console.ReadLine();
            }
            while (!reg.IsMatch(NewSurname))
            {
                Console.WriteLine(SetCursor("Input you real surname:"));
                NewSurname = Console.ReadLine();
            }

            for (var i = 0; i < 16; i++)
            {
                Card_Number_[i] = rand.Next(9);
            }
        }
    }
}
