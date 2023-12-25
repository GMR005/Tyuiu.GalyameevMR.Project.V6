using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GalyameevMR.Project.V6.Lib;


namespace Tyuiu.GalyameevMR.Project.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheclFile()
        {
            string path = @"C:\visual studio\Tyuiu.GalyameevMR.Sprint7\Tyuiu.GalyameevMR.Project.V6\bin\Debug\PacientBase.csv";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExist = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
