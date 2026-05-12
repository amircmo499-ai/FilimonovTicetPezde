using System;


//билет 5
namespace Ticket
{
    //создаем класс Student
   class Student
    {
        //создаем поля в которых будут значения   name будет храниться имя age возраст
        public string Name = "Амир";
        public int Age = 17;
    }
    class Program
    {
        static void Main(string[] args)
        { 
            //создаем экземпляр  класс Student чтобы в дальнейшем обратится к полям класса
            Student student = new Student();

            //Выводим  значения полей класса Student
            Console.WriteLine($" Имя: {student.Name} Возраст: {student.Age}");
        }
    }

 
}