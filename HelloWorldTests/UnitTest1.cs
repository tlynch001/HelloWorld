using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;

namespace HelloWorldTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello World", Program.CreateMessage());
        }

        [TestMethod]
        public void AddTest1()
        {
            Assert.AreEqual(10, Program.AddNumbers(5, 5));
        }
    }
}
