using System;
using System.Collections.Generic;

//билет 29
namespace Ticket
{
    
    class Program
    {
        static void Main(string[] args)
        { 
            //создаем коллекцию  ключ значение ключ строка значение число
            Dictionary<string,int> moth = new Dictionary<string, int>()
            {
                ["Январь"] = 31,
                ["Февраль"] = 28, 
                ["Март"] = 31,
                ["Апрель"] = 30,
                ["Май"] = 31,
                ["Июнь"] = 30,
                ["Июль"] = 31,
                ["Август"] = 31,
                ["Сентябрь"] = 30,
                ["Октябрь"] = 31,
                ["Ноябрь"] = 30,
                ["Декабрь"] = 31
            };
           
        }
       
        
    }

 
}