using System;
using tpJenkins;
using NUnit.Framework;

[assembly: CLSCompliant(true)]
namespace TestUnitaire
{
    [TestFixture()]
    public class UnitTest1
    {
        private Program calculateur = new Program();
        
        [Test]
        public void TestAdd()
        {
            int result = calculateur.Add(14 , 16);
            Assert.AreEqual(30, result);
        }

        [Test]
        public void TestDision()
        {
            int result = calculateur.Division(27, 3);
            Assert.AreEqual(9, result);
        }



    }
}
