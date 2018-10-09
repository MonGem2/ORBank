using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORBank
{
    class ORBank
    {
        User user;
        Dictionary<string, decimal> deposit;
        public static void Start()
        {
            Main_Menu.Menu();
        }

        

        public void StartWork(User NewUser)
        {
            user = NewUser;
        }
    }
}
