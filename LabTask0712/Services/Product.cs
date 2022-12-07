using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class Product
    {
        private static int _no;
        public int No { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int DiscountPercent { get; set; }
        static Product()
        {
            _no = 0;
        }
        public Product()
        {
            _no++;
            No = _no;
        }
    }
}
