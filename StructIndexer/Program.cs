using Core.Models;
namespace StructIndexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Book book1 = new Book("Oxford English", "Oxford University", 358);
            Book book2 = new Book("The Da Vinci Code", "Dan Brown", 201);
            Book book3 = new Book("The Algorithm", "Steven", 485);
            Book book4 = new Book("Atomic Habits", "James Clear", 147);
            Book book5 = new Book("Advanced Data Structures", "Peter Brass", 571);
            Book book6 = new Book("C# fundamentals", "Kodlab", 523);
            Book book7 = new Book("Informatika", "Qanun", 410);
            Book book8 = new Book("Fizika", "Qanun", 275);
            Book book9 = new Book("Riyaziyyat", "Qanun", 186);
            Book book10 = new Book("The Secret", "Rhonda B.", 200);

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);
            library.AddBook(book6);
            library.AddBook(book7);
            library.AddBook(book8);
            library.AddBook(book9);
            library.AddBook(book10);


            Console.WriteLine("FindAllBooksByName() - metodundan istifade : \n");
            foreach (Book book in library.FindAllBooksByName("Fizika"))
            {
                Console.WriteLine(book.ToString());
            }

            Console.WriteLine("\n");
            library.RemoveAllBooksByName("Riyaziyyat");
            Console.WriteLine("\n");


            Console.WriteLine("SearchBooks() - metodundan istifade : \n");

            foreach (Book book in library.SearchBooks("Qanun"))
            {
                Console.WriteLine(book.ToString());
            }
        }
    }
}
