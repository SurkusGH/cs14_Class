using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace cs14_paskaita_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cs14_paskaita_Class");

            // 1. Book entity
            // 2. Books repository
            // 3. Repository saves a book in a file

            // 4. Check if such a book already exists,
            // if so add a counter to an existing one
            // (For example a book is saved like this "Twilight 7"
            //
            // 5.Create a Reader entity which is capable of "borrowing"
            // a book which means getting it from file(therefore removing
            // 1 from counter) and putting it into a private list.
            //
            // 6. Create a method in a Reader class to give a book back
            // therefore adding +1 in a file and removing from its private list.

            var bookList = new BookRepository(new List<Book>());

            var book1 = new Book("LotR1", "Tolkien", "1954 ");
            var book2 = new Book("LotR2", "Tolkien", "1955 ");
            var book3 = new Book("LotR3", "Tolkien", "1956"); 

            bookList.BookSavingFunction(book1);
            bookList.BookSavingFunction(book2);
            bookList.BookSavingFunction(book3);

            var FileWriterService = new FileWriterService();

            //bookList.WriteSegmentedDataToTXT(book1);
            //bookList.WriteSegmentedDataToTXT(book2);
            //bookList.WriteSegmentedDataToTXT(book3);

            bookList.WriteListDataToTXT();

            var bookchecking = new ContentChecker(new List<string>());
            bookchecking.ContentCheckerMethod();
        }
    }
}

