using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using tyuiu.axyonovma.sprint0.task2.v0.lib;

namespace tyuiu.axyonovma.sprint0.task2.v0.test
{
    [TestClass]
    public class dataservicetest
    {
        [TestMethod]
        public void checkgetmessagevalid()
        {
            var name = "Максим";
            var res = DataService.getmessage(name);
            Assert.AreEqual("Привет, Максим", res);
        }
    }
}
