using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AxyonovMA.Sprint0.Task4.V0.Lib;

namespace Tyuiu.AxyonovMA.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChekAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        [TestMethod]
        public void ChekSubtractionInvalid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }

        [TestMethod]
        public void ChekMultiplicationInvalid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }

        [TestMethod]
        public void ChekDivisionInvalid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}
