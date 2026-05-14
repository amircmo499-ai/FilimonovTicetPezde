
using System;

//билет 8
namespace Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
             //записываем  значение в переменную str
            string str = "Жусупов";

            //выводим результат метода Substring который  возращает значения диапазона который мы передали
            Console.WriteLine(str.Substring(0,3));
        }
    }
        
}

