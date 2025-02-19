using System;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Исходные данные
            int[] massTest1 = new int[] {5, 6, 84, 2, 7, 9};
            int expected = 108;

            //Получение значения с помощью тестируемого метода
            CMass massTesting = new CMass(massTest1);
            int actual = massTesting.compositionMass();

            //Сравнение ожидаемого результата с полученным

            Assert.AreEqual(expected, actual);
        }
    }
}
