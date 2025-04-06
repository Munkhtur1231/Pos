using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosLibrary
{
    public class Payment
    {
        public double TotalPrice { get; set; }
        public double PaidAmount { get; set; }
        public double Change { get; set; }

        public Payment()
        {
            TotalPrice = 0;
            PaidAmount = 0;
            Change = 0;
        }

        public void calc()
        {
            if (PaidAmount > TotalPrice)
            {
                Change = PaidAmount - TotalPrice;
            } else
            {
                Change = 0;
            }
        }
    }
}
