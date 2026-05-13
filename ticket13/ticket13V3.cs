using System;

//билет 13
namespace Ticket
{
    
    class Program
    {
        //создаем делегат(он же указател  на метод) который будет принимать 2 значения типа double  и возращает  тип double
         delegate double MathOperation(double num1,double num2);
        static void Main(string[] args)
        {
            //присваиваем  переменой типа нашего делегата MathOperation и присваиваем туда  лямду  
            // лямда  принимает   2 значения  типа double  и возращает тип double  (в лямде не написан  тип  потому что компилятор сам понимает что подставить)
           MathOperation summOperation = ( num1, num2) => num1 + num2;
           //вызываем нашу  переменую summOperation  и отдаем  как методу Summ  значения в скобки и забираем результат 
           double result = summOperation(12,23);
        }
        
        
        
        
    }

 
}