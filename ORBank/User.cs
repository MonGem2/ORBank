using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORBank
{
    class User
    {
        private Decimal Money;
        public Decimal Wallet
        {
            get { return Money+65; }
            set { Money = value-65; }
        }

        private string Login;
        private string LogIn
        {
            get { return Login; }
            set { Login = value; }
        }

        private string PassWord;
        private string Password
        {
            get { return PassWord; }
            set { PassWord = value; }
        }

        private string Card_Number;
        public string CardNum
        {
            get { return Card_Number; }
        }

        private string PIN;
        public string PINcode
        {
            get { return PIN; }
            set { PIN = value; }
        }
    }
}
