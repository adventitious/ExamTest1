using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using examTest1Sol;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddTwoNumbers()
        {
            // Arrange
            UtileFuncs uf = new UtileFuncs();

            // Act
            int x = uf.AddTwoNumbers(5, 7);

            // Assert
            Assert.AreEqual(x, 12);
        }
    }
}
