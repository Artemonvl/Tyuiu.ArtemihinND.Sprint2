using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ArtemihinND.Sprint2.Task4.V19.Lib;

namespace Tyuiu.ArtemihinND.Sprint2.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 59.9;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 15;
            double res = ds.Calculate(x, y);
            double wait = 0.486;
            Assert.AreEqual(wait, res);
        }
    }
}
