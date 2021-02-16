using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Acme.Common
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var source = "SonicScrewderiver";
            var expected = "Sonic Screwdriver";
            var handler = new StringHandler();

            // Act
            var actual = handler.InsertSpaces(source);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
