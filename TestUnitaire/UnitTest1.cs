using System;
using TpJenkins;
using NUnit.Framework;

[assembly: CLSCompliant(true)]
namespace TestUnitaire
{
    [TestFixture()]
    public class UnitTest1
    {
     
        
        [Test]
        public void TestAdd()
        {
            int result = Program.Add(14 , 16);
            Assert.AreEqual(30, result);
        }

        [Test]
        public void TestDision()
        {
            int result = Program.Division(27, 3);
            Assert.AreEqual(9, result);
        }
    }
}
