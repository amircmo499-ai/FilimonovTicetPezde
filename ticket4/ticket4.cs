using System;


//билет 4
namespace Ticket
{
   class Program
    {
         static void Main(string[] args)
        {
            //присваиваем переменной summNumber сумму которую вернул метод Summa
            double summNumber = Summa(4,5);
        }

        //создаем метод для подсчета  суммы которая принимает 2 значения типа double  и также позращает тип  double
        static double Summa(double num1,double num2)
        {
            //возращаем  сумму
            return num1 + num2;
        }
    }
 
}