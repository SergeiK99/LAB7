using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LAB7;

namespace LAB7test
{
    [TestClass]
    public class Zadanie4Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            Zadanie4 t = new Zadanie4();
            bool actual = t.z4("skx2013@mail.ru");
            bool expected = true;
            Assert.AreEqual(actual, expected);
        }
    }
}
