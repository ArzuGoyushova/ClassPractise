using System;
using Services;
using Domain.Models;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {

            //genre ishlemir bax

            LibraryService libraryService = new LibraryService();
            Console.WriteLine(libraryService.IsExistBookByNo(2));

            Book findBook = libraryService.FindBookByNo(3);
            Console.WriteLine(findBook?.Name);

            List<Book> gerne = libraryService.FilterByGenre();
            foreach(var item in gerne)
            {
                Console.WriteLine($"name={item?.Name}");
            }
            Console.WriteLine("----------");
            foreach (var item in libraryService.BookList())
            {
                Console.WriteLine(item.Name);
            }
           //libraryService.RemoveAll(n => n.Id==4);
            Console.WriteLine("----------");
            foreach (var item in libraryService.RemoveAll(n => n.Id == 4))
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}