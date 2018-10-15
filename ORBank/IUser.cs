using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORBank
{
    interface IUser
    {
        string Name { get; set; }

        string SurName { get; set; }

        Wallet wallet { get; set; }

        string LogIn { get; set; }

        string Password { get; set; }

        string CardNum { get; }

        string PINcode { get; set; }

        string Phone_Number { get; set; }

        void Save();

        void ViewProfile();


    }
}
