using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tp_jenkins;



namespace TestUnitaire
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            int result = tp_jenkins.Program.Add(14 , 16);
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void TestDision()
        {
            int result = tp_jenkins.Program.Division(27, 3);
            Assert.AreEqual(9, result);
        }
    }
}
