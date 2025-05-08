using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosLibrary
{
    public class Payment
    {
        /// <summary>
        /// Төлбөрийн нийт дүн
        /// </summary>
        public double TotalPrice { get; set; }
        /// <summary>
        /// Төлсөн дүн
        /// </summary>
        public double PaidAmount { get; set; }
        /// <summary>
        /// Хариулт
        /// </summary>
        public double Change { get; set; }
        /// <summary>
        /// Төлбөрийн анхны утга
        /// </summary>
        public Payment()
        {
            TotalPrice = 0;
            PaidAmount = 0;
            Change = 0;
        }
        /// <summary>
        /// Төлбөрийн дүнг тооцоолох
        /// </summary>
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
