using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosLibrary
{

    public partial class Product
    {
        /// <summary>
        /// Барааны ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Барааны нэр
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Барааны үнэ
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Барааны төрөл
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Барааны зураг
        /// </summary>
        public byte[]? Image { get; set; }

        //public int BarCode { get; set; }
    }
}
