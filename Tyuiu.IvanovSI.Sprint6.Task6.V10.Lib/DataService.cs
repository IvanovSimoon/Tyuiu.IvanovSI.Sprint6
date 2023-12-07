using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
namespace Tyuiu.IvanovSI.Sprint6.Task6.V10.Lib
{
    public class DataService
    {
        
        public string CollectTextFromFile(string str, string path)
        {
            
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(str))
                    {
                        resStr = resStr + " " + line;
                    }
                }
            }
            return resStr;

        }
    }
}
