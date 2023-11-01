using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DolgushinVA.Sprint4.Task2.V19.Lib;
namespace Tyuiu.DolgushinVA.Sprint4.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 8, 5, 4, 4, 7, 8, 5, 5, 6, 5, 7, 6, 9, 4 };
            int res = ds.Calculate(array);
            int wait = 43;
            Assert.AreEqual(wait, res);
        }
    }
}
