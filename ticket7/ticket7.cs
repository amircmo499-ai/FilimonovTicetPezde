using  System;

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
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Зима");
                    break;
                    
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Весна");
                    break;

                case 6:
                case 7: 
                case 8:
                    Console.WriteLine("Лето");
                    break;

                case 9: 
                case 10: 
                case 11:
                    Console.WriteLine("Осень");
                    break;

                default:
                    Console.WriteLine("Ошибка ввода");
                    break;
            }
        }
    }
        
}

