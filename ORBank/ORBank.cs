using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ORBank
{
    class ORBank
    {
        User user;
        Admin adm;
        Dictionary<string, decimal> deposit;
        public static void Start()
        {
            Main_Menu main_menu = new Main_Menu();
            main_menu.Menu();
        }

        void Bank_Menu_User()
        {

            while (true)
            {
                Console.Clear();
                Main_Menu.Print_Logotype_Fast();
                int variant_ = Main_Menu.Variant(new List<string> { "View profile","Create deposit","Refill wallet",
                    "Withdraw money","Change account","Sign Out"});
                if (variant_ == 0)
                {
                    adm.ViewProfile();
                }
                if (variant_ == 4)
                { }
                if (variant_ == 5)
                { }
                if (variant_ == 6)
                { }
                if (variant_ == 7)
                {
                    adm.ChangeProfile();
                }
                if (variant_ == 8)
                {
                    return;
                }
            }
        }

        public void StartWork(User NewUser)
        {
            user = NewUser;

            Bank_Menu_User();
        }

        void Bank_Menu_Adm()
        {
            
            while (true)
            {
                Console.Clear();
                Main_Menu.Print_Logotype_Fast();
                int variant_ = Main_Menu.Variant(new List<string> { "View profile" ,"Block user","Unblock user","Delete user",
                "Create deposit","Refill wallet","Withdraw money","Change account","Sign Out"});
                if (variant_ == 0)
                {
                    adm.ViewProfile();
                }
                if (variant_ == 1)
                {
                    adm.Block_User();
                }
                if (variant_ == 2)
                {
                    adm.Unblock_User();
                }
                if (variant_ == 3)
                {
                    adm.Delete_User();
                }
                if (variant_ == 4)
                { }
                if (variant_ == 5)
                { }
                if (variant_ == 6)
                { }
                if (variant_ == 7)
                {
                    adm.ChangeProfile();
                }
                if (variant_ == 8)
                {
                    return;
                }
            }
        }

        public void StartWork(Admin NewAdm)
        {
            adm = NewAdm;

            Bank_Menu_Adm();

        }
    }
}
