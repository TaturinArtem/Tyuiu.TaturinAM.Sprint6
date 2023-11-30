using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TaturinAM.Sprint6.Task0.V3.Lib;
namespace Tyuiu.TaturinAM.Sprint6.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calc()
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            Assert.AreEqual(4.154, res);
        }
    }
}
