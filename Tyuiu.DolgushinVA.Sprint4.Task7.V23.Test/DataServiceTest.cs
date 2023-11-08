using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DolgushinVA.Sprint4.Task7.V23.Lib;
namespace Tyuiu.DolgushinVA.Sprint4.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string value = "678135972584";
            int m = 4;
            int n = 3;
            int[,] matrix = new int[m, n];
            int res = ds.Calculate(n, m, value);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}
