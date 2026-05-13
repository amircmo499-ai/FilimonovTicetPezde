using System;


//билет 18
namespace Ticket
{
   
   //создаем  перечисление с  названиями дней (Monday = 1  присваиваем  1   потому что   если не напишем будет счисление начинаться с 0)
    enum Day
    {
        Monday = 1,
        Tuesday ,
        Wednesday,
        Thursday ,
        Friday ,
        Saturday,
        Sunday 
    }
    class Program
    {
        static void Main(string[] args)
        { 
            //безопастно переводим строку в число  в тип byte  потому что   нам не нужно большое число
            byte.TryParse(Console.ReadLine(),out byte day);
            //переводим число в название  дня недели 
            Console.WriteLine((Day)day);
        }
    }
}