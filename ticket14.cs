using System;


//билет 14
namespace Ticket
{
    //создаем интерфейс IDrawable который будем реализовывать 
    interface IDrawable
    {
        //создаем метод который должен быть реализован
        void Draw();
    }
    //создаем класс ImplementsDrawable  и пишем что он будет реализовывать интерфейс IDrawable
    class ImplementsDrawable : IDrawable
    {
        //реализуем метод внутри интрефейса 
        public void Draw()
        {
            Console.WriteLine("Я умею рисовать");
        }
    }
    class Program
    {
        static void Main(string[] args)
        { 
            
        }
        
        
    }

 
}