using System;

namespace Pharmacy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TypeDrug typeDrug1 = new TypeDrug("Vitamin");
            TypeDrug typeDrug2 = new TypeDrug("Eye drop");
            Drug drug1 = new Drug("Swiss Energy", typeDrug1, 22.80, 5);
            Drug drug2 = new Drug("Slezol Forte", typeDrug2, 4.50, 10);
            Drug drug3 = new Drug("Momi", typeDrug1, 20, 15);

            Pharmacy pharmacy = new Pharmacy("Aptek");
            Console.WriteLine(pharmacy.ToString());

            pharmacy.AddDrugs(drug1);
            pharmacy.AddDrugs(drug2);
            pharmacy.AddDrugs(drug3);

            Console.WriteLine("List before the sale:");
            pharmacy.DrugList();

            Console.WriteLine(pharmacy.SaleDrug("Swiss Energy",1,22.80));
            Console.WriteLine("List after the sale:");
            pharmacy.DrugList();
        }
    }
}
