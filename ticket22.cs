using System;

//создаем 1 пространство имен
namespace Namaespase1
{
    //создаем класс student 
    public class Student
    {
        //конструктор чтобы при создание экземпляра  свойства небыли пустыми
        public Student()
        {
            Age = 23;
            Name = "Dalina";
        }
        //свойства в которых будут храниться данные
        public int Age { get; set; }
        public string Name { get; set; }
    }
}
//создаем 2 пространство имен
namespace Namaespase2
{
    //создаем статический класс infostudent 
   static class InfoStudent
    {
        //статический метод PrintInfoStudent для вывода  информации о студенте
        public static void PrintInfoStudent(Namaespase1.Student student)
        {
            Console.WriteLine($"Имя {student.Name} возрастр {student.Age}");
        }
    }
}

//билет 22
namespace Ticket
{
    //подключаем пространства имен
    using Namaespase1;
    using Namaespase2;

    class Program
    {
        
        static void Main(string[] args)
        { 
            //создаем экземпляр класса Student
            Student student = new Student();

            //передаем его в статический класс InfoStudent а именно в метод PrintInfoStudent
           InfoStudent.PrintInfoStudent(student);
        }
    }
}
