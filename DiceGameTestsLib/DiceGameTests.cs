using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiceGameLib;
using System.Diagnostics;

namespace DiceGameTestsLib
{
    [TestClass]
    public class DiceGameTests
    {
        [TestMethod]
        public void ThrowDices()
        {
            Random random = new Random();
            var sut = new Game(random);
            while (!sut.IsWinner)
            {
                sut.ThrowDices();
                Debug.WriteLine(sut.ToString());
            }
            Debug.WriteLine($"Won after {sut.ThrowsMade} throws.");
            Assert.AreEqual(7, sut.NumberOfPoints);
        }
    }
}
