using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.DolgushinVA.Sprint4.Task7.V23.Lib
{
    public class DataService : ISprint4Task7V23
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[m, n];
            int count = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(value[i * n + j].ToString());
                    if (matrix[i, j] % 2 == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
