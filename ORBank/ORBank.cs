using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ORBank
{
    [Serializable]
    class ORBank
    {
        [NonSerialized] User user;
        Dictionary<string, Deposit> deposit = new Dictionary<string, Deposit>();
        public static void Start()
        {
            Main_Menu main_menu = new Main_Menu();
            main_menu.Menu();
        }

        public void StartWork(User NewUser)
        {
            user = NewUser;
            try
            {
                deposit[user.LogIn].UpDate();
            }
            catch { }
                Bank_Menu();
            
        }

        void Bank_Menu()
        {
            while (true)
            {
                Console.Clear();
                Main_Menu.Print_Logotype_Fast();
                List<string> menu = new List<string> {"View profile" , "Create deposit","Take a deposit","Refill wallet","Withdraw money",
                    "Change account","Sign Out"};
               
                    
                    
                if (user is Admin)
                {
                    menu.Add("Block user");
                    menu.Add("Unblock user");
                    menu.Add("Delete user");
                    

                }

                int variant_ = Main_Menu.Variant(menu);

                if (variant_ == 0)
                {
                    user.ViewProfile();
                }
                if (variant_ == 1)
                {
                    deposit.Add(user.LogIn,user.CreateDeposit());
                    SaveDepos();
                }
                if (variant_ == 2)
                {
                    user.TakeDeposit(deposit[user.LogIn]);
                }
                if (variant_ == 3)
                {
                    user.wallet = new Wallet(user.wallet.Moneys + 1000);
                    user.Save();
                }
                if (variant_ == 4)
                {
                    Console.WriteLine("We sorry, but you can`t withdraw money :(");
                    Console.ReadKey(true);
                }
                if (variant_ == 5)
                {
                    user.ChangeProfile();
                }
                if (variant_ == 6)
                {
                    return;
                }
                if (variant_ == 7)
                {
                    Admin adm = (Admin)user;
                    adm.Block_User();
                }
                if (variant_ == 8)
                {
                    Admin adm = (Admin)user;
                    adm.Unblock_User();
                }
                if (variant_ == 9)
                {
                    Admin adm = (Admin)user;
                    adm.Delete_User();
                }


            }
        }

        public void SaveDepos()
        {
            using (FileStream fileStream = new FileStream($@"files\Bank\Deposits.ob", FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, this);
            }

        }
    }
}
