using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace JayshreeFramework28thMay17Latest
{
    [TestFixture]

    class TestClassSet:Base
    {
        [Test]
        public void TestCase1()
        {
            Console.WriteLine("Test case1 execution");
            sw.WriteLine("Tesr case1 execution");
        }

        [Test]

        public void TestCase2()
        {
            Console.WriteLine("Test case2 execution");
            sw.WriteLine("Tesr case2 execution");
        }

    }
}
