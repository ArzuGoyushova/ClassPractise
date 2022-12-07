using Services;
using System;

namespace LabTask0712
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook1 = new Notebook();
            notebook1.Name = "Acer";
            notebook1.Price = 2000;
            notebook1.DiscountPercent = 20;
            notebook1.RAM = "8GB";
            notebook1.Storage = "15GB";

            Notebook notebook2 = new Notebook();
            notebook2.Name = "Asus";
            notebook2.Price = 2000;
            notebook2.DiscountPercent = 20;
            notebook2.RAM = "8GB";
            notebook2.Storage = "15GB";

            Phone phone1 = new Phone();
            phone1.Name = "Samsung";
            phone1.Price = 2500;
            phone1.DiscountPercent = 20;
            phone1.SimCount = 2;


            Store store = new Store();
            Store.NotebookLimit = 3;
            Store.PhoneLimit = 5;
            store.AddProduct(notebook1);
            store.AddProduct(notebook2);
            store.AddProduct(phone1);

            foreach (var item in store.products)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine(store.CalcNotebookAvg());
            Console.WriteLine(store.CalcPhoneAvg());

            Console.WriteLine(store.FindByNo(3)?.Name);
        }
    }
}
