using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.VdovichenkoAI.Sprint5.Task7.V23.Lib;

namespace Tyuiu.VdovichenkoAI.Sprint5.Task7.V23.Test
{
    [TestClass]
    public class DataSerivceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = $@"C:\DataSprint5\OutPutDataFileTask7V23.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
