using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class Store
    {
        public Product[] products;
        public Phone[] phones;
        public Notebook[] notebook;
        public Store()
        {
            products = new Product[0];
            phones = new Phone[0];
            notebook = new Notebook[0];
        }
        public static int NotebookLimit;
        public static int PhoneLimit;
        public void AddProduct(Product newProduct)
        {
           if (newProduct is Notebook)
            {
                Array.Resize(ref notebook, notebook.Length + 1);
                notebook[notebook.Length - 1] = (Notebook)newProduct;
            }

           if (newProduct is Phone)
            {
                Array.Resize(ref phones, phones.Length + 1);
                phones[phones.Length - 1] = (Phone)newProduct;
            }

           if (newProduct is Notebook && notebook.Length <= NotebookLimit )
            {
                Array.Resize(ref products, products.Length + 1);
                products[products.Length - 1] = newProduct;
            }
            else if (newProduct is Phone && phones.Length <= PhoneLimit)
            {
                Array.Resize(ref products, products.Length + 1);
                products[products.Length - 1] = newProduct;
            }
        }

        public Product FindByNo(int searchNo)
        {
            foreach(var item in products)
            {
                if (searchNo == item.No)
                {
                    return item;
                }
            }
            return null;         
        }

        public double CalcNotebookAvg()
        {
            double sum = 0;
            foreach(var item in notebook)
            {
                sum +=item.Price;
            }
            return sum / notebook.Length;
        }
        public double CalcPhoneAvg()
        {
            double sum = 0;
            foreach (var item in phones)
            {
                sum += item.Price;
            }
            return sum / phones.Length;
        }
    }
}
