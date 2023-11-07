using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DolgushinVA.Sprint4.Task5.V18.Lib;
namespace Tyuiu.DolgushinVA.Sprint4.Task5.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { 4, -6, 3, -1, 7 },
                                            { 5, 3, -5, 7, -2 },
                                            { 3, 7, 2, -4, -6 },
                                            { -5, 2, 4, -6, -4 },
                                            { 1, 4, 3, 7, -2 } };
            int[,] res = ds.Calculate(matrix);
            int[,] wait = { { 4, 0, 3, 0, 7 },
                            { 5, 3, 0, 7, 0 },
                            { 3, 7, 2, 0, 0 },
                            { 0, 2, 4, 0, 0 },
                            { 1, 4, 3, 7, 0 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
