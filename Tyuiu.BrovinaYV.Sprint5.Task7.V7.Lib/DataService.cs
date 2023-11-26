using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BrovinaYV.Sprint5.Task7.V7.Lib
{
    public class DataService : ISprint5Task7V7
    {
        public string LoadDataAndSave(string path)


        {
            string pathSaveFile = @"C:\Users\broth\source\repos\Tyuiu.BrovinaYV.Sprint5\Tyuiu.BrovinaYV.Sprint5.Task7.V7\bin\Debug\OutPutDataFileTask7V7.txt";
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }
            string text = File.ReadAllText(path, Encoding.UTF8);
            string modifiedText = Regex.Replace(text, "[А-Я]", string.Empty, RegexOptions.IgnoreCase);
            File.AppendAllText(pathSaveFile, modifiedText + Environment.NewLine, Encoding.UTF8);
            return pathSaveFile;



        }
    }
}
