using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        private string title; // private field
        private string author; // private field
        private string isbn; // private field

        //Title property to allow access to the title private field
        public string Title
        {
            get { return title; } // Get Method
            set { title = value; } // Get Method
        }

        public string Author
        {
            get { return author; } // Get Method
            set { author = value; } // Get Method
        }

        public string ISBN
        {
            get { return isbn; } // Get Method
            set { isbn = value; } // Get Method
        }

        // Example of a constructor that allows us to 'construct' a new Book object
        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            this.Title = bookTitle;
            this.Author = bookAuthor;
            this.ISBN = bookISBN;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
}
