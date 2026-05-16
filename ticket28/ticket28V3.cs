using System;
using System.Runtime.InteropServices;


//билет 28
namespace Ticket
{
    
    class Program
    {
        static async Task Main(string[] args)
        { 
            //получаем какойто обьект
            object  data = "Dalina";

            //проверяем на наличие строки если true  то приведем к string
            if(data is string )
            {
                //приводим тип к string
                string str = (string)data;
                Console.WriteLine(str.Length);
            }
            else
                Console.WriteLine("это не строка");
            
            
        }
       
        
    }

 
}