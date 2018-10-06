using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;


namespace ORBank
{
    [Serializable]
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

        private Wallet Money_;
        public Wallet wallet
        {
            get { return Money_; }
            set { Money_ = value; }
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

        private string Card_Number_;
        public string CardNum
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
            string Main_File = @"files\main_file.ob";
            FileInfo file = new FileInfo(Main_File);
            string[] str_file=null;
            try
            {
                str_file = File.ReadAllLines(Main_File);
            }
            catch { 
            if (str_file==null||str_file.Length==0)
            {
                Worker.CreateUser();
                //LoadUser();
            }
                // else LoadUser();
            }
        }

        public delegate string Cursor(string x);
        public static Cursor SetCursorToCenter = (x) => { Console.SetCursorPosition((Console.WindowWidth - x.Length) / 2, Console.CursorTop); return x; };

        
           
    }
}
