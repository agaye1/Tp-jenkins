using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestUnitaireNunit
{
    public class TestUnit
    {
        [Test]
        public void TestAdd()
        {
            int result = tp_jenkins.Program.Add(14, 16);
            Assert.AreEqual(30, result);
        }

        [Test]
        public void TestDision()
        {
            int result = tp_jenkins.Program.Division(27, 3);
            Assert.AreEqual(9, result);
        }

        [Test]
        public void divisionZero()
        {
            Assert.Throws<DivideByZeroException>(() => tp_jenkins.Program.Division(6, 0));
        }

        static void Main(string[] args)
        {
            
        }
    }
}
