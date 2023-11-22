using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BrovinaYV.Sprint5.Task4.V8.Lib
{
    public class DataService : ISprint5Task4V8
    {
        public double LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);
            double res = Math.Round(((Math.Pow(Convert.ToDouble(str),2)/Math.Sin(Convert.ToDouble(str)))+3),3);
            return res;
        }
    }
}
