using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.BrovinaYV.Sprint5.Task1.V17.Lib;

namespace Tyuiu.BrovinaYV.Sprint5.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\broth\source\repos\Tyuiu.BrovinaYV.Sprint5\Tyuiu.BrovinaYV.Sprint5.Task1.V17\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
