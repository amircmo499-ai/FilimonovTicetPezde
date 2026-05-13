using System;


//билет 24
namespace Ticket
{
   //создаем базовый класс Animal от которого будет происходить наследование
    class Animal
    {
        //создаем  метод MakeSound  virtual тоесть который мы можем переопределить
        public virtual void MakeSound()
        {
            Console.WriteLine("звук животного");
        }
    }
    // создаем класс наследник Dog который будет наследоваться от  базового класса  Animal 
    class Dog : Animal
    {
        //переопределяем метод MakeSound  который виртуальный с помощью override
        public override void MakeSound()
        {
            Console.WriteLine("гав");
        }
    }
    class Program
    {
        static void Main(string[] args)
        { 
            
        }
        
        
    }

 
}