using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Reflection.Metadata.Ecma335;
using System.Threading;
using static NizamiTask.Program;

namespace NizamiTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(PreCount(b=>b=="Nizami"));
        }

        public static int PreCount(Predicate<string> function)
        {

            Book book1 = new Book();
            book1.Author = "Nizami";

            Book book2 = new Book();
            book2.Author = "Nesimi";

            Book book3 = new Book();
            book3.Author = "Nizami";

            List<Book> books = new List<Book>();
            books.Add(book1);
            books.Add(book2);
            books.Add(book3);

            int count = 0;
            foreach(Book book in books)
            {
                if (function(book.Author))
                {
                    count++;
                }
            }

            //List<Book> NizamiBooks = books.FindAll(b => b.Author == "Nizami");
            //return NizamiBooks.Count

            return count;
        }
    }
    public class Book
    {
       public string Author { get; set; }
    }
}
