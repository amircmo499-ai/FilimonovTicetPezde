using System;


//билет 28
namespace Ticket
{
    
    class Program
    {
        static async Task Main(string[] args)
        { 
            //получаем какойто обьект
            object  data = "Dalina";

            //переводим безопастно его в строку
            string text = data as string;

            //проверяем далась нам строка или нет
            Console.WriteLine(text == null? "это не текст": text.Length());
        }
       
        
    }

 
}