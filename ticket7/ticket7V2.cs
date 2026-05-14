using System;

//билет 7
namespace Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            // запрашиваем ввод с консоли  и конвертируе в  тип byte  потому что нам не нужно большое число
            byte.TryParse(Console.ReadLine(),out byte month);

            //проверяем число на диапазоны если попал  то выводим сезон если нет  то пишем ошибка ввода
            if(month == 12 || month == 1 || month == 2) Console.WriteLine("Зима");
            else if(month == 3 || month == 4 || month == 5) Console.WriteLine("Весна");
            else if(month == 6 || month == 7 || month == 8) Console.WriteLine("Лето");
            else if(month == 9 || month == 10 || month == 11) Console.WriteLine("Осень");
            else Console.WriteLine("Ошибка ввода");
            
              
               
        }
    }
        
}

