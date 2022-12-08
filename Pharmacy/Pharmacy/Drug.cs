using System;
using System.Collections.Generic;
using System.Text;

namespace Pharmacy
{
    public class Drug
    {
        private static int _Id;
        public int Id { get; set; }
        public string Name { get; set; }
        public TypeDrug Type { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }

        public Drug(string name, TypeDrug type, double price, int count)
        {
            _Id++;
            Id = _Id;
            Name = name;
            Type = type;
            Price = price;
            Count = count;
        }

        public override string ToString()
        {
            return $"DrugID={Id}, Name={Name}, Type={Type}, Price={Price},Count={Count}";
        }
    }
}
