using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace HelloWorldTest
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello World";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
               Console.SetOut(sw);
                PR1_Testirovanie.Program.HelloWorld();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }          
        }

        private const string Expected2 = "GoodbyeWorld";
        [TestMethod]
        public void TestMethod2()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                PR1_Testirovanie.Program.GoodbyeWorld();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected2, result);
            }
        }

    }
}
