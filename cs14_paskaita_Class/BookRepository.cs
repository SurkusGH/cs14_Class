using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace cs14_paskaita_Class
{
    // 2. Books repository
    // 3. Repository saves a book in a file
    public class BookRepository
	{
        public List<Book> BookList;

        public BookRepository(List<Book> bookList)
        {
            BookList = bookList;
        }

        public void BookSavingFunction(Book book)
        {
            BookList.Add(book);
        }

        public void WriteBookNameToTXT (Book book)
        {
            var FileWriterService = new FileWriterService();
            FileWriterService.AppendText(book.BookName);
        }
        public void WriteSegmentedDataToTXT(Book book)
        {
            var FileWriterService = new FileWriterService();
            FileWriterService.AppendText(book.BookName);
            FileWriterService.AppendText(book.Author);
            FileWriterService.AppendText(book.BookRealeaseDate);
            FileWriterService.AppendText("---");
        }

        public void WriteListDataToTXT()
        {
            var FileWriterService = new FileWriterService();
            //FileWriterService.WriteAllText(BookList.ToArray()); <-- nenori veikti, todėl primityviai:

            string[] listToArray = new string [9];
            var bookchecking = new ContentChecker(new List<string>());
            bookchecking.ContentCheckerMethod();

            int x = 0;
            for (int i = 0; i < BookList.Count; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    listToArray[x++] = BookList[j].BookName;
                    listToArray[x++] = BookList[j].Author;
                    listToArray[x++] = BookList[j].BookRealeaseDate;
                }
            }
            FileWriterService.WriteAllText(listToArray);
        }
    }
}

