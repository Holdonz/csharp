using System;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    //Здесь так тем более я ничего не понимаю, для чего это как это и тд.
    //Но рано или поздно я пойму, что здесь да как.
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double p = 3.14;
            double r = 3;
            double h = 4;
            double expected = 113.04;
            Geometry g = new Geometry();
            double actual = g.RectangleArea(p, r, h);

            Assert.AreEqual(expected, actual);
        }
    }
}
