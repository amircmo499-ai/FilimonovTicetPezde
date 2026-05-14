using System;



namespace Ticket25Console
{
    //подключаем нашу библеотеку  в которой класс Print
    using Ticket25;

    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //создаем  экземпляр класса Print  из библеотеки Ticket25
            Print print = new Print();
            //вызываем метод
            print.Write("Dalina");
        }
    }
}
