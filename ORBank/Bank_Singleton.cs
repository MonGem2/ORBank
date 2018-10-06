using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORBank
{
    class Bank_Singleton
    {
        
        private static Bank_Singleton instance;

        private Bank_Singleton()
        {
            Main_Menu.Menu();
        }

        public static Bank_Singleton getInstance()
        {
            if (instance == null)
                instance = new Bank_Singleton();
            return instance;
        }
    }
}
