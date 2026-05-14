using  System;

//билет 8
namespace Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
             //записываем  значение в переменную str
            string str = "Жусупов";


            //перебираем первые 3 символа в  str (можите выбрать лбой другой цикл я выбрал for)
            for(byte i = 0; i < 3; ++i)
            {
                //выводим значения о индексу они же  символы  char 
                Console.Write(str[i]);
            }
            //делаем отступ в выводе
            Console.WriteLine();
        }
    }
        
}

