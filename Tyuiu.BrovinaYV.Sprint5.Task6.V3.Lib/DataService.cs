using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.BrovinaYV.Sprint5.Task6.V3.Lib
{
    public class DataService : ISprint5Task6V3
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i=0; i < line.Length; i++)
                    {
                        if (('a' <= line[i] && line[i] <= 'z') || ('A' <= line[i] && line[i] <= 'Z'))
                        {
                            count++;
                        }
                    }
                }

            
            }
            return count;
            
        }
    }
}
