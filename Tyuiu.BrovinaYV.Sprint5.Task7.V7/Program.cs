using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.BrovinaYV.Sprint5.Task7.V7.Lib;

namespace Tyuiu.BrovinaYV.Sprint5.Task7.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Бровина Ю. В. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант 7                                                               *");
            Console.WriteLine("* Выполнила: Бровина Юлия Викторовна | АСОиУб-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Удалить все заглавные русские буквы из файла.Полученный результат       *");
            Console.WriteLine("* сохранить в файл OutPutDataFileTask7V7.txt.                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask7V7.txt";
            string pathSaveFile = @"C:\Users\broth\source\repos\Tyuiu.BrovinaYV.Sprint5\Tyuiu.BrovinaYV.Sprint5.Task7.V7\bin\Debug\OutPutDataFileTask7V7.txt";

            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);

            Console.ReadKey();
        }
    }
}
