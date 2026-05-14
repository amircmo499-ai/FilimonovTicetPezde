using System;

//билет 1
namespace Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            // считываем результат  что введут из консоли и присваиваем в numGesult  (TryParse если введут не число кинет  ошибку)
            int.TryParse(Console.ReadLine(),out int numResult); 

                //с помощью тернального оператора  проверяем та четность  и  выводим
            Console.WriteLine(numResult % 2 == 0 ? "четное": "нечетное");
        }
    }
        
}

