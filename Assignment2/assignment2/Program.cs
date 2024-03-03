using System;

namespace LibraryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Book book1 = new PhysicalBook("Book1", "Author1");
            Book book2 = new EBook("Book2", "Author2", "PDF");

            library.AddBook(book1);
            library.AddBook(book2);

            Console.WriteLine("Initial library information:");
            Console.WriteLine("Number of books: " + library.GetBookCount());
            Console.WriteLine();

            library.BorrowBook("Book1");

            Console.WriteLine("Library information after borrowing Book1:");
            Console.WriteLine("Number of books: " + library.GetBookCount());
            Console.WriteLine();

            library.ReturnItem(DateTime.Now);

            Console.WriteLine("Library information after returning a book:");
            Console.WriteLine("Number of books: " + library.GetBookCount());

            Console.ReadLine();
        }
    }
}