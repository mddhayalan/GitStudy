using Microsoft.VisualStudio.TestTools.UnitTesting;
using api;
using System;
using System.Collections.Generic;
using System.Text;

namespace api.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void TestMethodTest()
        {
            var expected = "hello World";
            Assert.Equals(api.Program.TestMethod(), expected);
        }
    }
}