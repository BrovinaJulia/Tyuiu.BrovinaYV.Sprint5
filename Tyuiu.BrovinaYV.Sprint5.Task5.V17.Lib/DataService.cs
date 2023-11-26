using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BrovinaYV.Sprint5.Task5.V17.Lib
{
    public class DataService : ISprint5Task5V17
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader=new StreamReader(path))
            {

                 bool IsPrime(double number)
                {
                    if (number < 2)
                    {
                        return false; 
                    }

                    for (double i = 2; i <= Math.Sqrt(number); i++)
                    {
                        if (number % i == 0)
                        {
                            return false; 
                        }
                    }

                    return true; 
                }

                string line;



                while  ((line = reader.ReadLine()) != null)
                {
                    if ((Convert.ToDouble(line) % 1 == 0)&&IsPrime(Convert.ToDouble(line)))                                            //&& (Convert.ToDouble(line) > 1)
                    {
                        res += Convert.ToDouble(line);
                    }

                }
            }
            return res;
        }
    }
}
