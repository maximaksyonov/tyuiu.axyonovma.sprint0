using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AxyonovMA.Task3.V0.Lib;

namespace Tyuiu.AxyonovMA.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChekValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}
