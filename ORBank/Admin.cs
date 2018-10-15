using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ORBank
{
    class Admin : Worker
    {
        public Admin(User user)
        {
            LogIn = user.LogIn;
            Name = user.Name;
            SurName = user.SurName;
            Phone_Number = user.Phone_Number;
            Password = user.Password;
            PINcode = user.PINcode;
            CardNum = user.CardNum;
            wallet = new Wallet(0);
        }

        public void Delete_User()
        {
            Console.WriteLine("Input login of user");
            string login = Console.ReadLine();
            try
            {
                Console.WriteLine($"Do you really want to delete this account?({login})");
                if (Main_Menu.Variant(new List<string> { "Yes", "NO" }) == 0)
                {
                    File.Delete(@"files\users\" + login + ".ob");
                }
                else return;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("This user not found :(");
                return;
            }
        }

        public void Block_User()
        {
            Console.WriteLine("Input login of user");
            string login = Console.ReadLine();
            try
            {
                Console.WriteLine($"Do you really want to block this account?({login})");
                if (Main_Menu.Variant(new List<string> { "Yes", "NO" }) == 0)
                {
                    File.Copy(@"files\users\" + login + ".ob", @"files\users\block\" + login + ".ob");
                    File.Delete(@"files\users\" + login + ".ob");
                }
                else return;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("This user not found :(");
                return;
            }
        }

        public void Unblock_User()
        {
            Console.WriteLine("Input login of user");
            string login = Console.ReadLine();
            try
            {
                Console.WriteLine($"Do you really want to unblock this account?({login})");
                if (Main_Menu.Variant(new List<string> { "Yes", "NO" }) == 0)
                {
                    File.Copy(@"files\users\block\" + login + ".ob", @"files\users\" + login + ".ob");
                    File.Delete(@"files\users\block\" + login + ".ob");
                }
                else return;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("This user not found :(");
                return;
            }
        }
    }
}
