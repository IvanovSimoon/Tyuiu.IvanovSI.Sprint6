using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.IvanovSI.Sprint6.Task3.V9.Lib
{
    public class DataService : ISprint6Task3V9
    {
        public int[,] Calculate(int[,] matrix)
        {

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < rows - 1 - i; j++)
                {
                    if (matrix[j, 4] > matrix[j + 1, 4])
                    {
                        
                        for (int k = 0; k < cols; k++)
                        {
                            int temp = matrix[j, 4];
                            matrix[j, 4] = matrix[j + 1, 4];
                            matrix[j + 1, 4] = temp;
                        }

                    }
                }
                
            }
            return matrix;
        }
    }
}