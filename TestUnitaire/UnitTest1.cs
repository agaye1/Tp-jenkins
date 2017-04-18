using System;
using tp_jenkins;
using NUnit.Framework;



namespace TestUnitaire
{
    [TestFixture()]
    public class UnitTest1
    {
        
        [Test]
        public void TestAdd()
        {
            int result = tp_jenkins.Program.Add(14 , 16);
            Assert.AreEqual(30, result);
        }

        [Test]
        public void TestDision()
        {
            int result = tp_jenkins.Program.Division(27, 3);
            Assert.AreEqual(9, result);
        }



    }
}
