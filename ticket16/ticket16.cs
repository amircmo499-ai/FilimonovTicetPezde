using System;


//билет 16
namespace Ticket
{
    //создаем статический  класс MathHelper 
    static class MathHelper
    {
        //создаем статический метод square который принимает число типа double   и возращает  квадрат  типа  double
        public static double square(double num)
        {
            return num * num;
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