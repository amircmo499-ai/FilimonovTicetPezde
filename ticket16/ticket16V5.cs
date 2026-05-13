using System;


//билет 16
namespace Ticket
{
    //создаем статический  класс MathHelper 
    static class MathHelper
    {
        //создаем статический метод square который принимает число типа double   и возращает  квадрат  типа  double
        //наш метод square вызывает в нутри себя еще  статический класс Math  с методом Pow которая возводит в квадрат
        public static double square(double num)
        {
            return Math.Pow(num,2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        { 
             //выводимм  что вернет метод square  из класса MathHelper
           Console.WriteLine(MathHelper.square(5)); 
        }
        
        
    }

 
}