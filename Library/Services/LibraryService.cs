using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class LibraryService
    {
        public  List<Book> BookList()
        {
            Genre genre1 = new Genre();
            Book book1 = new Book();
            book1.Name = "Beartown";
            book1.AuthorName = "Frederik Backman";
            book1.Price = 25;
            book1.Id = 1;
            book1.genre = Domain.Models.Genre.Drama;
            

            Book book2 = new Book();
            book2.Name = "Alias Grace";
            book2.AuthorName = "Margaret Atwood";
            book2.Price = 26;
            book1.genre = Domain.Models.Genre.Romance;
            book1.Id = 2;

            Book book3 = new Book();
            book3.Name = "Dede Qorqud";
            book3.AuthorName = "Xalq dastani";
            book3.Price = 15;
            book3.genre = Domain.Models.Genre.Romance;
            book3.Id = 3;

            Book book4 = new Book();
            book4.Name = "Koroglu";
            book4.AuthorName = "Xalq dastani";
            book4.Price = 12;
            book4.genre = Domain.Models.Genre.Romance;
            book4.Id = 4;

            List<Book> Books = new List<Book>();
            Books.Add(book1);
            Books.Add(book2);
            Books.Add(book3);
            Books.Add(book4);
            return Books;
        }


        public List<Book> FilterByPrice(double min, double max)
        {
            List<Book> newList = new List<Book>();
            foreach (Book book in BookList())
            {

                if (book.Price>=min && book.Price <= max)
                {
                    newList.Add(book);
                }
            }
            return newList;
        }

        public List<Book> FilterByGenre()
        {
            List<Book> newGenre = new List<Book>();
            foreach (Book book in BookList())
            {
                if (book.genre == Domain.Models.Genre.Drama)
                    //eslinde ==genre1
                {
                    newGenre.Add(book);
                }
            }
            return newGenre;
        }

    
        public Book FindBookByNo(int no)
        {

            foreach(Book book in BookList())
            {
                if (book.Id==no)
                {
                    return book;
                }
            }
            return null;
        }

        public bool IsExistBookByNo(int no)
        {
            foreach (Book book in BookList())
            {
                return book.Id == no;
            }
            return false;
           
        }
        public List<Book> RemoveAll(Predicate<Book> function)
        {
            List<Book> Removed = new List<Book>();
            foreach (Book book in BookList())
            {
                if (function(book))
                {
                    BookList().Remove(book);
                }
                else
                {
                    Removed.Add(book);
                }
            }
            return Removed;
        }
    }
}
