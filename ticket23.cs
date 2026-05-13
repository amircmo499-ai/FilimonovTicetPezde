using System;


//билет 23
namespace Ticket
{
    class Book
    {
        public string Author {set; get;}
        public string Title {set; get;}
        public Book(string author,string title)
        {
            Author = author;
            Title = title;
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        { 
            Book book = new Book("Dalina",",билеты филимонова");
        }
    }
}
