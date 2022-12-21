using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LAB7;

namespace LAB7test
{
    [TestClass]
    public class Zadanie5Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            Zadanie5 t = new Zadanie5();
            int actual = t.z5("12345");
            int expected = 15;
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            bool catched = false;
            Zadanie5 t = new Zadanie5();
            try
            {
                int value = Convert.ToInt32(t.z5("Hello"));

            }
            catch (ArgumentException e)
            {
                catched = true;
            }
            Assert.IsTrue(catched, "не обработаны недопустимые данные");
        }
    }
}
