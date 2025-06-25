using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ArtemihinND.Sprint2.Task2.V4.Lib;

namespace Tyuiu.ArtemihinND.Sprint2.Task2.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 4;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
