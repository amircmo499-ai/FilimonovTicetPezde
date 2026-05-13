using System;


//билет 11
namespace Ticket
{
    
    class Program
    {
        static void Main(string[] args)
        { 
            //создаем переменные в которых будут числа для подсчета
            int num1 =6,num2=0;

            //делаем блок try чтобы отлавливать исключения в  нашем случае мы отлавливаем DivideByZeroException 
            try
            {
                //делаем  подсчет которое кинет исключение
                Console.WriteLine(num1 / num2);
                
            }//ловим исключение
            catch(DivideByZeroException ex)
            {  
                 //выводим сообщение + сообщение об ошибке
                Console.WriteLine("деление на 0 "+ ex.Message);
            }
        }
        
        
    }

 
}