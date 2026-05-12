using System;


//билет 6
namespace Ticket
{
   //создаем класс Rectangle он будет считать  периметр и площадь прямоугольника
    class Rectangle
    {
        //создаем метод Perimeter для подсчета периметра  принимает 2  значения типа double и возращает тип double
        public double Perimeter(double a, double b)
        {
            //возращаем  подсчет
            return 2 * ( a + b );
        }

        //создаем метод Area для подсчета площади  принимает 2  значения типа double и возращает тип double
        public double Area(double a, double b)
        {
            //возращаем  подсчет
            return a * b;
        }

    }
    class Program
    {
        static void Main(string[] args)
        { 
            //создаем экземпляр  класс Rectangle чтобы в дальнейшем обратится к методам класса
            Rectangle rectangle = new Rectangle();


            //создаем 2 переменые в которые записываем  результат подсчета  из методов
            double perimeter = rectangle.Perimeter(3,5);
            double area = rectangle.Area(3,4);
        }
    }

    
}