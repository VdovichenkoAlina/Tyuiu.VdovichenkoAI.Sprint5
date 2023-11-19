using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.VdovichenkoAI.Sprint5.Task0.V5.Lib;

namespace Tyuiu.VdovichenkoAI.Sprint5.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Пользователи\Администратор\source\repos\Tyuiu.VdovichenkoAI.Sprint5\Tyuiu.VdovichenkoAI.Sprint5.Task0.V5\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
