using System;
using System.Collections.Generic;
using System.Text;

namespace CodingCSharp
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book()
        {
            Console.WriteLine("Creating a new book object...");
        }

        public Book(string author, string title, int pages)
        {
            this.author = author;
            this.title = title;
            this.pages = pages;
        }

        override public string ToString()
        {
            return "Title: " + this.title + ", Author: " + this.author + ", Pages: " + this.pages;
        }
    }
}
