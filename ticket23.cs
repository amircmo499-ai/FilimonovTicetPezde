using System;


//билет 23
namespace Ticket
{
    // создаем класс Book
    class Book
    {
        //автореализующие свойства Author Title
        public string Author {set; get;}
        public string Title {set; get;}

        //создаем конструктор класса 
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
            //создаем экземпляр   и передаем туда значения
            Book book = new Book("Dalina",",билеты филимонова");
        }
    }
}
