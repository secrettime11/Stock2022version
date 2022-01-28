using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Tests
{
    [TestClass()]
    public class UnitTests
    {
        [TestMethod]
        public void MethodTesr() 
        {
            var Sut = new Unit();

            var expected = 7;

            var actual = Sut.Model1();

            Assert.AreEqual(expected, actual);
        }

        
    }
}