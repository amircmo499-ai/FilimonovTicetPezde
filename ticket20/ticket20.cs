using System;
using System.Collections.Generic;
using System.Linq;

//билет 20
namespace Ticket
{
    class Program
    {
      
        static void Main(string[] args)
        { 
            //создаем коллекцию  типа int  с числами (Можно туже тему сделать с масивами)
            List<int> collection = new List<int>(){123,6,25,7,2336,48,8,457,4};

            //записываем  отфильтрованую коллекцию в новую коллекцию
            //  (если не написать метод ToList() то мы получим обьект типа IEnumerable<int>) 
            var SortCollection = (from i in collection
                                    where i % 2 ==0 
                                    select i).ToList();
           
        }
    
    }
}