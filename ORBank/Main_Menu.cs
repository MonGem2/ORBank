using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;

namespace ORBank
{
    class Main_Menu : MenuAbstract
    {
        Random rand = new Random();

        public override void Menu()
        {
            while (true)
            {
                User user;
                Console.Clear();
                Print_Logotype();

                int variant_ = Variant(new List<string> { "Sign In", "Sign Up", "Exit" });

                if (variant_ == 0)
                {
                    if ((user = User.SignIn()) != null)
                    {
                        ORBank or = new ORBank();

                        if (user.LogIn[0] == 'a' && user.LogIn[1] == 'd' && user.LogIn[2] == 'm' && user.LogIn[3] == '\\')
                        {
                            Admin adm = new Admin(user);
                            or.StartWork(adm);
                        }
                        else
                            or.StartWork(user);
                    }
                }
                if (variant_ == 1)
                {
                    while ((user = Worker.CreateUser()) == null) { }
                }
                if (variant_ == 2)
                {
                    return;
                }
            }
        }
    }
}
