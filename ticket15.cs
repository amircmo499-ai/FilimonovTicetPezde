using System;


//билет 15
namespace Ticket
{
   //создаем базовый класс Car от которого будет происходить наследование
    class Car
    {
        //создаем  метод   virtual тоесть который мы можем переопределить
        public virtual void Drive()
        {
            Console.WriteLine("машина едет");
        }
    }
    // создаем класс наследник Vehicle который будет наследоваться от  базового класса  Car 
    class Vehicle : Car
    {
        //переопределяем метод Drive  который виртуальный с помощью override
        public override void Drive()
        {
            Console.WriteLine("транспортное средство едет");
        }
    }
    class Program
    {
        static void Main(string[] args)
        { 
            
        }
        
        
    }

 
}