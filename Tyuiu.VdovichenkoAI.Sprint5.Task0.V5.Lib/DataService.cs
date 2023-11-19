using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VdovichenkoAI.Sprint5.Task0.V5.Lib
{
    public class DataService : ISprint5Task0V5
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double res = Math.Round((Math.Pow(x, 3) - 1) / (4 * Math.Pow(x, 2)), 3);
            File.WriteAllText(path, Convert.ToString(res));
            return path;
        }
    }
}
