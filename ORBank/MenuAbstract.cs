using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ORBank
{
    class MenuAbstract
    {
        public delegate string Cursor(string x);
        public static Cursor SetCursor = (x) => { Console.SetCursorPosition((Console.WindowWidth - x.Length) / 2, Console.CursorTop); return x; };

        public static void Print_Logotype()
        {
            Console.CursorVisible = false;
            Console.Title = "ORBank";
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetWindowSize(140, 35);
            Console.WriteLine(SetCursor(
      " .-----------------. ")); Console.WriteLine(SetCursor(
      "| .---------------. |")); Console.WriteLine(SetCursor(
      "| |     _____     | |")); Console.WriteLine(SetCursor(
     @"| |   .' ::: `.   | |")); Console.WriteLine(SetCursor(
     @"| |  /  .-╒-.  \  | |")); Console.WriteLine(SetCursor(
     @"| |  | ├──┼──┤¤|  | |")); Console.WriteLine(SetCursor(
     @"| |  \  `-╛-'  /  | |")); Console.WriteLine(SetCursor(
     @"| |   `._____.'   | |")); Console.WriteLine(SetCursor(
      "| |               | |")); Console.WriteLine(SetCursor(
      "| '---------------' |")); Console.WriteLine(SetCursor(
      " '-----------------' "));
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine(SetCursor(
      " .-----------------.  .----------------. ")); Console.WriteLine(SetCursor(
      "| .---------------. || .--------------. |")); Console.WriteLine(SetCursor(
      "| |     _____     | || |  _______     | |")); Console.WriteLine(SetCursor(
     @"| |   .' ::: `.   | || | |_   __ \    | |")); Console.WriteLine(SetCursor(
     @"| |  /  .-╒-.  \  | || |   | |__) |   | |")); Console.WriteLine(SetCursor(
     @"| |  | ├──┼──┤¤|  | || |   |  __ /    | |")); Console.WriteLine(SetCursor(
     @"| |  \  `-╛-'  /  | || |  _| |  \ \_  | |")); Console.WriteLine(SetCursor(
     @"| |   `._____.'   | || | |____| |___| | |")); Console.WriteLine(SetCursor(
      "| |               | || |              | |")); Console.WriteLine(SetCursor(
      "| '---------------' || '--------------' |")); Console.WriteLine(SetCursor(
      " '-----------------'  '----------------' "));

            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine(SetCursor(
      " .-----------------.  .----------------.  .----------------. ")); Console.WriteLine(SetCursor(
      "| .---------------. || .--------------. || .--------------. |")); Console.WriteLine(SetCursor(
      "| |     _____     | || |  _______     | || |   ______     | |")); Console.WriteLine(SetCursor(
     @"| |   .' ::: `.   | || | |_   __ \    | || |  |_   _ \    | |")); Console.WriteLine(SetCursor(
     @"| |  /  .-╒-.  \  | || |   | |__) |   | || |    | |_) |   | |")); Console.WriteLine(SetCursor(
     @"| |  | ├──┼──┤¤|  | || |   |  __ /    | || |    |  __'.   | |")); Console.WriteLine(SetCursor(
     @"| |  \  `-╛-'  /  | || |  _| |  \ \_  | || |   _| |__) |  | |")); Console.WriteLine(SetCursor(
     @"| |   `._____.'   | || | |____| |___| | || |  |_______/   | |")); Console.WriteLine(SetCursor(
      "| |               | || |              | || |              | |")); Console.WriteLine(SetCursor(
      "| '---------------' || '--------------' || '--------------' |")); Console.WriteLine(SetCursor(
      " '-----------------'  '----------------'  '----------------' "));
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine(SetCursor(
      " .-----------------.  .----------------.  .----------------.  .----------------. ")); Console.WriteLine(SetCursor(
      "| .---------------. || .--------------. || .--------------. || .--------------. |")); Console.WriteLine(SetCursor(
      "| |     _____     | || |  _______     | || |   ______     | || |      __      | |")); Console.WriteLine(SetCursor(
     @"| |   .' ::: `.   | || | |_   __ \    | || |  |_   _ \    | || |     /  \     | |")); Console.WriteLine(SetCursor(
     @"| |  /  .-╒-.  \  | || |   | |__) |   | || |    | |_) |   | || |    / /\ \    | |")); Console.WriteLine(SetCursor(
     @"| |  | ├──┼──┤¤|  | || |   |  __ /    | || |    |  __'.   | || |   / ____ \   | |")); Console.WriteLine(SetCursor(
     @"| |  \  `-╛-'  /  | || |  _| |  \ \_  | || |   _| |__) |  | || | _/ /    \ \_ | |")); Console.WriteLine(SetCursor(
     @"| |   `._____.'   | || | |____| |___| | || |  |_______/   | || ||____|  |____|| |")); Console.WriteLine(SetCursor(
      "| |               | || |              | || |              | || |              | |")); Console.WriteLine(SetCursor(
      "| '---------------' || '--------------' || '--------------' || '--------------' |")); Console.WriteLine(SetCursor(
      " '-----------------'  '----------------'  '----------------'  '----------------' "));
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine(SetCursor(
      " .-----------------.  .----------------.  .----------------.  .----------------.  .-----------------.")); Console.WriteLine(SetCursor(
      "| .---------------. || .--------------. || .--------------. || .--------------. || .--------------. |")); Console.WriteLine(SetCursor(
      "| |     _____     | || |  _______     | || |   ______     | || |      __      | || | ____  _____  | |")); Console.WriteLine(SetCursor(
     @"| |   .' ::: `.   | || | |_   __ \    | || |  |_   _ \    | || |     /  \     | || ||_   \|_   _| | |")); Console.WriteLine(SetCursor(
     @"| |  /  .-╒-.  \  | || |   | |__) |   | || |    | |_) |   | || |    / /\ \    | || |  |   \ | |   | |")); Console.WriteLine(SetCursor(
     @"| |  | ├──┼──┤¤|  | || |   |  __ /    | || |    |  __'.   | || |   / ____ \   | || |  | |\ \| |   | |")); Console.WriteLine(SetCursor(
     @"| |  \  `-╛-'  /  | || |  _| |  \ \_  | || |   _| |__) |  | || | _/ /    \ \_ | || | _| |_\   |_  | |")); Console.WriteLine(SetCursor(
     @"| |   `._____.'   | || | |____| |___| | || |  |_______/   | || ||____|  |____|| || ||_____|\____| | |")); Console.WriteLine(SetCursor(
      "| |               | || |              | || |              | || |              | || |              | |")); Console.WriteLine(SetCursor(
      "| '---------------' || '--------------' || '--------------' || '--------------' || '--------------' |")); Console.WriteLine(SetCursor(
      " '-----------------'  '----------------'  '----------------'  '----------------'  '----------------' "));

            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine(SetCursor(
      " .-----------------.  .----------------.  .----------------.  .----------------.  .-----------------. .----------------. ")); Console.WriteLine(SetCursor(
      "| .---------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. |")); Console.WriteLine(SetCursor(
      "| |     _____     | || |  _______     | || |   ______     | || |      __      | || | ____  _____  | || |  ___  ____   | |")); Console.WriteLine(SetCursor(
     @"| |   .' ::: `.   | || | |_   __ \    | || |  |_   _ \    | || |     /  \     | || ||_   \|_   _| | || | |_  ||_  _|  | |")); Console.WriteLine(SetCursor(
     @"| |  /  .-╒-.  \  | || |   | |__) |   | || |    | |_) |   | || |    / /\ \    | || |  |   \ | |   | || |   | |_/ /    | |")); Console.WriteLine(SetCursor(
     @"| |  | ├──┼──┤¤|  | || |   |  __ /    | || |    |  __'.   | || |   / ____ \   | || |  | |\ \| |   | || |   |  __'.    | |")); Console.WriteLine(SetCursor(
     @"| |  \  `-╛-'  /  | || |  _| |  \ \_  | || |   _| |__) |  | || | _/ /    \ \_ | || | _| |_\   |_  | || |  _| |  \ \_  | |")); Console.WriteLine(SetCursor(
     @"| |   `._____.'   | || | |____| |___| | || |  |_______/   | || ||____|  |____|| || ||_____|\____| | || | |____||____| | |")); Console.WriteLine(SetCursor(
      "| |               | || |              | || |              | || |              | || |              | || |              | |")); Console.WriteLine(SetCursor(
      "| '---------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' |")); Console.WriteLine(SetCursor(
      " '-----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------' "));
        }

        public static void Print_Logotype_Fast()
        {
            Console.WriteLine(SetCursor(
      " .-----------------.  .----------------.  .----------------.  .----------------.  .-----------------. .----------------. ")); Console.WriteLine(SetCursor(
      "| .---------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. |")); Console.WriteLine(SetCursor(
      "| |     _____     | || |  _______     | || |   ______     | || |      __      | || | ____  _____  | || |  ___  ____   | |")); Console.WriteLine(SetCursor(
     @"| |   .' ::: `.   | || | |_   __ \    | || |  |_   _ \    | || |     /  \     | || ||_   \|_   _| | || | |_  ||_  _|  | |")); Console.WriteLine(SetCursor(
     @"| |  /  .-╒-.  \  | || |   | |__) |   | || |    | |_) |   | || |    / /\ \    | || |  |   \ | |   | || |   | |_/ /    | |")); Console.WriteLine(SetCursor(
     @"| |  | ├──┼──┤¤|  | || |   |  __ /    | || |    |  __'.   | || |   / ____ \   | || |  | |\ \| |   | || |   |  __'.    | |")); Console.WriteLine(SetCursor(
     @"| |  \  `-╛-'  /  | || |  _| |  \ \_  | || |   _| |__) |  | || | _/ /    \ \_ | || | _| |_\   |_  | || |  _| |  \ \_  | |")); Console.WriteLine(SetCursor(
     @"| |   `._____.'   | || | |____| |___| | || |  |_______/   | || ||____|  |____|| || ||_____|\____| | || | |____||____| | |")); Console.WriteLine(SetCursor(
      "| |               | || |              | || |              | || |              | || |              | || |              | |")); Console.WriteLine(SetCursor(
      "| '---------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' |")); Console.WriteLine(SetCursor(
      " '-----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------' "));
        }

        public static int Variant(List<string> variant)
        {
            foreach (var item in variant)
            {
                Console.WriteLine(SetCursor(item));
            }
            Console.ForegroundColor = ConsoleColor.Black;
            int variant_ = 0;
            bool some = false;


            for (; !some;)
            {

                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.UpArrow)
                    variant_--;
                if (key == ConsoleKey.DownArrow)
                    variant_++;
                if (key == ConsoleKey.W)
                    variant_--;
                if (key == ConsoleKey.S)
                    variant_++;
                if (key == ConsoleKey.Enter)
                    some = true;

                if (variant_ >= variant.Count)
                {
                    variant_ = 0;
                }
                if (variant_ < 0)
                {
                    variant_ = variant.Count - 1;
                }

                Console.Clear();
                Print_Logotype_Fast();

                for (int i = 0; i < variant.Count && !some; i++)
                {
                    if (i == variant_)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(SetCursor(variant[i]));
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(SetCursor(variant[i]));
                    }

                }


            }
            return variant_;
        }

        public virtual void Menu() { }
    }
}
