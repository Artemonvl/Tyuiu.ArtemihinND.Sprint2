using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ArtemihinND.Sprint2.Task1.V10.Lib;

namespace Tyuiu.ArtemihinND.Sprint2.Task1.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 135;
            int b = 156;
            int c = 154;
            int d = 174;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { true, true, true, true, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
