using  System;

//билет 2
namespace Ticket
{
  
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем цикл на 100 итераций 
            // (можно выбрать любой цикл  я выбрал for  потому что он в данной ситуации будет удобней)
            for(int i = 1; i <= 100; ++i)
            {
                //проверяем на кратнойсть 5  и если кратен выводим эти числа
                if(i % 5 == 0) Console.WriteLine(i);            
            }
        }
    }

        
}

