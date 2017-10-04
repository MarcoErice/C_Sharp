using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonNumberLib;

namespace PersonNumberTestsLib
{
    [TestClass]
    public class PersonNumberTests
    {
        [TestMethod]
        public void marco()
        {
            // Arrange
            var sut = new PersonNumber();

            // Act
            sut.Process("780622929");
            var expected = "5";

            // Assert
            Assert.AreEqual(expected, sut.LastDigit);


        }
    }
}
