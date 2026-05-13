using System;
using System.Collections.Generic;

//билет 12
namespace Ticket
{
    
    class Program
    {
        static void Main(string[] args)
        { 
            //создаем коллекцию List для типа int  на 5 элементов (тип  и количество элементов можете вбрать свой)
            List<int> collectionInt = new List<int>(){123,53,363,84,88};

            //добавляем  элемент  в коллекцию  с помощью метода Add
            collectionInt.Add(15);

            //удаляем элемент  из коллекции с помощью метода Remove
            collectionInt.Remove(84);
        }
        
        
    }

 
}