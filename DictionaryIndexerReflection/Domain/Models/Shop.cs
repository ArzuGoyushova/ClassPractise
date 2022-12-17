using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Shop : IEnumerable
    {
        private Product[] products;
        public Shop(int index)
        {
            products = new Product[index];
        }
        public Product this[int index]
        {
            get
            {
                return products[index];

            }
            set
            {
                if (products.Length < index)
                {
                    Console.WriteLine("Couldn't set");
                    return;
                }
                products[index] = value;
            }
        }

       
    }
}
