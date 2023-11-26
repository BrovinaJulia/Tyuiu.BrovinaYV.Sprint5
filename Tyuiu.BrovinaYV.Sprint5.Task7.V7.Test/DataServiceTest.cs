using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.BrovinaYV.Sprint5.Task7.V7.Lib;

namespace Tyuiu.BrovinaYV.Sprint5.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\broth\source\repos\Tyuiu.BrovinaYV.Sprint5\Tyuiu.BrovinaYV.Sprint5.Task7.V7\bin\Debug\OutPutDataFileTask7V7.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
