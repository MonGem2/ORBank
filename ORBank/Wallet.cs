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
        DateTime dateTime;
        public decimal Moneys { get; private set; }

        public Wallet(decimal Money)
        {
            Moneys = Money;
        }

        public decimal Get_Wallet()
        {
            return Moneys;
        }

        void Percent_Bonus()
        {
            dateTime = new DateTime();
            dateTime = DateTime.Today;
            FileStream fs = new FileStream(@"files\date.ob", FileMode.OpenOrCreate, FileAccess.Read);
            

            fs.Close();
        }

        public override string ToString()
        {
            return ((int)Moneys).ToString();
        }
    }
}
