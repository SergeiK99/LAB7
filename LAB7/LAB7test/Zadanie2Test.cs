using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LAB7;

namespace LAB7test
{
    [TestClass]
    public class Zadanie2Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            Zadanie2 t = new Zadanie2();
            double[] actual = t.z2(5.8, 10.2, 2.4);
            double[] expect = { -0.28, -1.47 };
            Assert.AreEqual(actual[0], expect[0], 2);
        }
    }
}
