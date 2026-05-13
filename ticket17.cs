using System;


//билет 17
namespace Ticket
{
    //создаем класс Person
    class Person
    {
        //создаем  автореализуемое свойство Name
        public string Name {set; get;}
        //создаем  автореализуемое свойство Age
        public byte Age {set; get;} 

        //конструктор чтобы инициализировать свойства (можно не писать)
        public Person()
        {
            Name = "Dalina";
            Age = 17;
        }
    }
    class Program
    {
        static void Main(string[] args)
        { 
            
        }
        
        
    }

 
}