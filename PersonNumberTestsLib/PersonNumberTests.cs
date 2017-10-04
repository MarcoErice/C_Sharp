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
            sut.calculateLastDigit("780622929");

            // Assert
            Assert.AreEqual("5", sut.LastDigit);


        }
    }
}
