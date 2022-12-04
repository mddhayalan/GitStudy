using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Tests
{
    [TestClass()]
    public class BroadcastTests
    {
        [TestMethod()]
        public void AdditionTest()
        {
            int x = 1;
            int y = 2;

            Assert.AreEqual(WebApplication1.Broadcast.Addition(x, y), x + y);
        }

        [TestMethod()]
        public void BroadcastMessageTest()
        {
            string expected = "Hello World";
            Assert.AreEqual(expected, Broadcast.BroadcastMessage());
        }
    }
}