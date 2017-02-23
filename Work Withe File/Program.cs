using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_Withe_File
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("C:\\Users\\днс\\Desktop\\txt.txt", "Hello, world!");// Дописвть - Исправить - Написать в файл

            // Путь относительно "текущей директории", которую можно узнать так:
            Console.WriteLine(Environment.CurrentDirectory);
            // Обычно это директория, в которой была запущена ваша программа

            // А размещение запущенного exe-файла можно узнать так:
            Console.WriteLine(System.Reflection.Assembly.GetExecutingAssembly().Location);

            // Сформировать абсолютный путь по относительному можно так:
            Console.WriteLine(Path.Combine(Environment.CurrentDirectory, "test.txt"));


            File.WriteAllLines("test1.txt", new[] { "Hello", "world" });

            File.WriteAllBytes("text.dat", new byte[10240]);

            // Чтение данных из файла
            string text = File.ReadAllText("text.txt");
            string[] lines = File.ReadAllLines("text1.txt");
            byte[] bytes = File.ReadAllBytes("text.dat");

            // Все файлы в текущей директории (точка в пути означает текущую директорию)
            foreach (var file in Directory.GetFiles("."))
                Console.WriteLine(file);
        }
    }
}
