using System;
using System.IO;

//билет 26
namespace Ticket
{
    //создаем класс который реализует   интерфейс IDisposable
    class ConectDB : IDisposable
    {
        // поле нужно для проверки делали ли мы очистку
        private bool disposing = false;

        //ресурс который нам нужно очистить
        private StreamReader file = new StreamReader();

        //сам метод интерфейса IDisposable для очистки ресурса  
        public void Dispose()
        {
            //проверяем на то что была ли очистка
            if(disposing) return;

            //очищаем  ресурс
            file.Dispose();
            disposing = true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        { 
            
        }
        
        
    }

 
}