using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace ORBank
{
    [Serializable]
    class Wallet
    {
        public decimal Moneys { get; private set; }

        public Wallet(decimal Money)
        {
            Moneys = Money;
        }

        public decimal Get_Wallet()
        {
            return Moneys;
        }

        public override string ToString()
        {
            return ((int)Moneys).ToString();
        }
    }
}
