using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AxyonovMA.Sprint0.Task6.V0.Lib;

namespace Tyuiu.AxyonovMA.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = Dataservice.AdditionArray(numbers);
            Assert.AreEqual(15, res);
        }

        [TestMethod]
        public void CheckSubstractionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = Dataservice.SubtractionArray(numbers);
            Assert.AreEqual(-15, res);
        }

        [TestMethod]
        public void CheckMultArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = Dataservice.MultiplicationArray(numbers);
            Assert.AreEqual(120, res);
        }
    }
}
