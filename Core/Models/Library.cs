using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core.Models
{
    public class Library
    {
        public Book[] Books = new Book[] { };
        public Book[] ForRemovedBooks = new Book[] { };
        public Book[] FilteredBooks = new Book[] { };
        public Book[] FoundBooks = new Book[] { };



        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = book;
        }

        public Book[] FindAllBooksByName(string name)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Name == name)
                {
                    Array.Resize(ref FilteredBooks, FilteredBooks.Length + 1);
                    FilteredBooks[FilteredBooks.Length - 1] = Books[i];
                }
            }
            return FilteredBooks;
        }

        public Book[] RemoveAllBooksByName(string name)
        {
            int count = 0;

            for (int i = 0; i < Books.Length; i++)
            {

                if (Books[i].Name == name)
                {
                    count++;
                }

                else if (Books[i].Name != name)
                {
                    Array.Resize(ref ForRemovedBooks, ForRemovedBooks.Length + 1);
                    ForRemovedBooks[ForRemovedBooks.Length - 1] = Books[i];
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Bele bir kitab bazada yoxdur");
            }

            else if (count > 0)
            {
                Console.WriteLine($"{name} - bazadan silindi!");
            }

            return FilteredBooks;
        }

        public Book[] SearchBooks(string value)
        {
            int intValue;

            if (int.TryParse(value, out intValue))
            {
                for (int i = 0; i < Books.Length; i++)
                {
                    if (Books[i].PageCount == intValue)
                    {
                        Array.Resize(ref FoundBooks, FoundBooks.Length + 1);
                        FoundBooks[FoundBooks.Length - 1] = Books[i];
                    }
                }
            }

            for (int i = 0; i < Books.Length; i++)
            {
                if ((Books[i].Name == value || Books[i].AuthorName == value))
                {
                    Array.Resize(ref FoundBooks, FoundBooks.Length + 1);
                    FoundBooks[FoundBooks.Length - 1] = Books[i];
                }
            }

            return FoundBooks;
        }






    }
}
