using  System;

//билет 1
namespace Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            // считываем результат  что введут из консоли и присваиваем в numGesult  (TryParse если введут не число кинет  ошибку)
            int.TryParse(Console.ReadLine(),out int numResult); 

            //проверяем с помощью конструкции if else
            if(numResult % 2 ==0)
                Console.WriteLine("число четное");
            else
                Console.WriteLine("число не четное");
                
        }
    }
        
}

