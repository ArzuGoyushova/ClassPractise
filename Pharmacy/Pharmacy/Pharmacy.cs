using System;
using System.Collections.Generic;
using System.Text;

namespace Pharmacy
{
    public class Pharmacy
    {
        private static int _Id;
        public int Id { get; set; }
        public string Name { get; set; }
        public Drug[] Drugs;
        public Pharmacy(string name)
        {
            _Id++;
            Id = _Id;
            Drugs = new Drug[0];
            Name = name;
        }

        public override string ToString()
        {
            return $"Pharmacy ID={Id} , Name={Name}";
        }
        public void AddDrugs(Drug drug)
        {
            if (drug is Drug)
            {
                Array.Resize(ref Drugs, Drugs.Length + 1);
                Drugs[Drugs.Length - 1] = (Drug)drug;
            }
        }

        public void DrugList()
        {
            foreach (var prod in Drugs)
            {
                Console.WriteLine($"Drug name={prod.Name} + Count={prod.Count}");
            }
        }

        public string SaleDrug(string drugName, int drugCount, double money)
        {
            foreach (var prod in Drugs)
            {
                if (prod.Name == drugName && prod.Count >= drugCount && prod.Price <= money)
                {
                    prod.Count -= drugCount; ;
                    return $"{drugCount} {drugName} is sold";
                }
            }
            return "Couldn't sell.";            
        }
    }
}
