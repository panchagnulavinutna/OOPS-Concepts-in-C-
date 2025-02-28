using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenges
{
    internal class Book
    {
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }
            public Book()
            {
                Title = "Unknown Title";
                Author = "Unknown Author";
                ISBN = "000-0000000000";
            }

            public Book(string title, string author)
            {
                Title = title;
                Author = author;
                ISBN = "000-0000000000"; 
            }

            public Book(string title, string author, string isbn)
            {
                Title = title;
                Author = author;
                ISBN = isbn;
            }
            public void DisplayBookInfo()
            {
                Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}");
            }
        }
}
