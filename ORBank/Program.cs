﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank_Singleton bank = Bank_Singleton.getInstance();
        }
    }
}
