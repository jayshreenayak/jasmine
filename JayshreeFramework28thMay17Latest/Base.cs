using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JayshreeFramework28thMay17Latest
{
    [TestFixture]
    public class Base
    {
        public StreamWriter sw;
       [OneTimeSetUp]
        public void BeforeTestScenario()
        {
            sw = new StreamWriter(@"E:\VisualStudioProject\JayshreeFramework28thMay17Latest\OutPut.Txt");
            sw.WriteLine("Before test scenario");
            
        }
        [TearDown]
        public void AfterTestMethod()
        {
            Console.WriteLine("After testmethod");
            sw.WriteLine("After test method");
        }
        [OneTimeTearDown]
        public void AfterTestScenario()
        {
            Console.WriteLine("After testscenario");
            sw.WriteLine("After test scenario");
            sw.Close();
        }
       




    }
}
