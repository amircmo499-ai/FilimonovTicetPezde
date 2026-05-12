using System;


//билет 9
namespace Ticket
{
    
    class Program
    {
        static void Main(string[] args)
        { 
             // создаем двухмерный масив 3 на 3 типа int  я расписал  указал точно  сколько на сколько можно сокращенно
            //пример int[,] array =
            // {
            //   {4,1,6},
            //   {2,7,1},
            //   {343,88,2}
            // }; 

            int[,] array = new int[3,3]
            {
                {4,1,6},
                {2,7,1},
                {343,88,2}
            };

            //создаем переменную для записи  суммы масива
            int summArray =0;

            //перебираем  каждый элемент масива и сумируе каждый элемент
            foreach (var value in array)
            {
                summArray += value;   
            }
        }
        
    }

 
}