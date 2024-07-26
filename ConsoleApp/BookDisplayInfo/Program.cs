using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDisplayInfo
{

        internal class Program
        {
            class Book
            {
                String title;
                String author;
                int pages;
                double price;

                // creating a Constructor
                public Book()
                {
                    title = "C#";
                    author = "microsoft";
                    pages = 0;
                }

                // Create a parameterized Constructor
                public Book(String title, String author, int pages)
                {
                    this.title = title;
                    this.author = author;
                    this.pages = pages;
                }

                public void BookInfo()
                {
                    Console.WriteLine($"Title : {title} Author : {author} Pages : {pages}");
                }
            }
            static void Main(string[] args)
            {
                Book book = new Book();
                book.BookInfo();



            }
        }
    }



