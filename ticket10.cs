using System;


//билет 10
namespace Ticket
{
    
    class Program
    {
        static void Main(string[] args)
        { 
            //записываем в переменныю factorial результат  метода Factorial
             int factorial = Factorial(5); 
        }
        static int Factorial(int i)
        {
            //условие при котором  рекурсия прекращает вызывать само себя
            if(i <= 1) return 1;

            //рекурсивно вызываем это же метод при этом уменьшаем i 
            return i * Factorial(i- 1);
        }
        
    }

 
}