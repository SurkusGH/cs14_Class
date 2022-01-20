using System;

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
            
            var Book1 = new Book("LotR", "Tolkien", "No idea");

            BookSavingFunction(Book1);

            System.IO.File.AppendText("Book_DB.txt").WriteLine("Your texxt");
        }

        
    }
}

