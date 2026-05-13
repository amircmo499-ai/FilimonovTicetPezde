using System;


//билет 19
namespace Ticket
{
   
   
    class Program
    {
        //создаем делегат для записи туда лямды  которая принимает значение типа double и принимает тип  double 
        delegate double Square (double square);
        static void Main(string[] args)
        { 
            //создаем переменую указатель на  метод в данной ситуации на лямду 
           Square square = (num) => num * num;
           
        }
    }
}