using System;
using System.Collections.Generic;

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

        public void BookSavingFunction(Book BookInstance)
        {
            BookList.Add(BookInstance);
        }
    }
}


