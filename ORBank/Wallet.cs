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
        public Decimal Moneys { get; private set; }

        public Wallet(Decimal Money)
        {
            Moneys = Money;
        }

        void Percent_Bonus()
        {
            dateTime = new DateTime();
            dateTime = DateTime.Today;
            FileStream fs = new FileStream(@"files\date.ob", FileMode.OpenOrCreate, FileAccess.Read);
            

            fs.Close();
        }

    }
}
