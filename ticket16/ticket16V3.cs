using System;


//билет 16
namespace Ticket
{
    //создаем статический  класс MathHelper 
    static class MathHelper
    {
        //создаем статический метод square который принимает число типа double   и возращает  квадрат  типа  double
        //this  нужен чтобы  вызывать метод сразу у переменой 
        public static double square( this double num)
        {
            return num * num;
        }
    }
    class Program
    {
        static void Main(string[] args)
        { 
            //создаем переменую у которой будем вызывать метод
           double num = 5;

           //вызываем метод у переменой  и выводим квадрат числа
           Console.WriteLine(num.square()); 
        }
        
        
    }

 
}