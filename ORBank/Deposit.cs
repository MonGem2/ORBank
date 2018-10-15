using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORBank
{
    class Deposit
    {
        double sum;
        DateTime lastupdate;
        DateTime createtime;
        float percent;

        public double Sum { get => sum; set => sum = value; }
        public DateTime Lastupdate { get => lastupdate; set => lastupdate = value; }
        public DateTime Createtime { get => createtime; set => createtime = value; }
        public float Percent { get => percent; set => percent = value; }

        public Deposit(double newsum)
        {
            Createtime = DateTime.Today;
            Percent = 3;
            Sum = newsum;
        }

        public void UpDate()
        {
            TimeSpan num = DateTime.Today - Lastupdate;
            if (num.Days / 30 >= 1)
            {
                Sum += num.Days / 30 * Sum * (Percent / 100);
                Lastupdate = DateTime.Today;
            }
        }

        public double Get_Sum()
        {
            return Sum;
        }

    }
}
