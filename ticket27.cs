using System;
using System.IO;
using System.Threading.Tasks;

//билет 27
namespace Ticket
{
    
    class Program
    {
        static async Task Main(string[] args)
        { 
            //пишем имя файла (можно указать  путь вместо названия только может бросить исключение  если путь будет не верный)
            //и желательно текст который  в файле  должен быть коротким а то оперативную память забьет
            string namefile = "dalina.txt";
            //если в файле который вы указали в путе  есть текст то вызов метода  CreateFile( можно удалить и сам метод тоже
            await CreateFile(namefile);

            //читаем соержимое  файла
            string textfile = await ReadFile(namefile);
        }
        static async Task<string> ReadFile(string namefile)
        {
            //делаем такую консрукцию  using  чтобы очистить память
            using(StreamReader file = new StreamReader(namefile))
            {
                //читаем весь фаил асихронно и дожидаемся

                return await file.ReadToEndAsync();
            }
        }
        static async Task CreateFile(string namefile)
        {
            //делаем такую консрукцию  using  чтобы очистить память
            using(StreamWriter file = new StreamWriter(namefile))
            {
                //вишем в фаил асихронно и дожидаемся
              await file.WriteLineAsync("Egor love 1C ");
            }
        }
        
    }

 
}