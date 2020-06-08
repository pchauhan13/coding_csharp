using System;
using System.Collections.Generic;
using System.Text;

namespace CodingCSharp
{
    class Book : Object
    {
        private string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        private string author;
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        private int pages;
        public int Pages
        {
            get
            {
                return pages;
            }
            set
            {
                pages = value;
            }
        }

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
