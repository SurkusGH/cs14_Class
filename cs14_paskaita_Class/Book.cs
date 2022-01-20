using System;
using System.Collections.Generic;

namespace cs14_paskaita_Class
{
	public class Book
	{
		// 1. Book entity
		// 2. Books repository
		// 3. Repository saves a book in a file

		public string BookName;
		public string Author;
		public string BookRealeaseDate;

        public Book(string bookName, string author, string bookRealeaseDate)
        {
            BookName = bookName;
            Author = author;
            BookRealeaseDate = bookRealeaseDate;
        }
    }
}

