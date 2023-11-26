using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VdovichenkoAI.Sprint5.Task6.V11.Lib
{
    public class DataService : ISprint5Task6V11
    {
        public int LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string r = File.ReadAllText(path).Replace(',', ' ');
                string[] str = r.Split(' ');
                int count = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i].Length == 6)
                        count++;
                }
                return count;
            }
        }
    }
}
