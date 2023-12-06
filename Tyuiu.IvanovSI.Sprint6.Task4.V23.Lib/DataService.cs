using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
namespace Tyuiu.IvanovSI.Sprint6.Task4.V23.Lib
{
    public class DataService : ISprint6Task4V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int cnt = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x != 1)
                {
                    y = Math.Round((4 - 2 * x + ((2 + Math.Cos(x)) / (2 * x - 2))), 2);
                }
                else
                {
                    y = 0;
                }
                

                valueArray[cnt] = y;
                cnt++;
            }

            return valueArray;
        }
    }
}
