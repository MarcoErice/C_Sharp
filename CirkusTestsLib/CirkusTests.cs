using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CirkusLib;

namespace CirkusTestsLib
{
    [TestClass]
    public class CirkusTests
    {
        [TestMethod]
        public void TestToString()
        {
            // Arrange
            Cirkus sut = new Cirkus("Elefanten");
            Artist clown = new Artist("Clownen Surskratt");
            Artist lindansaren = new Artist("Lindansaren Repo");
            sut.Anställ(clown);
            sut.Anställ(lindansaren);
            sut.ArtistUppträdande(clown);
            sut.ArtistUppträdande(lindansaren);
            sut.ArtistUppträdande(lindansaren);
            var expected = "Cirkusen Elefanten har 2 artister. Clownen Surskratt har uppträtt 1 gång. Lindansaren Repo har uppträtt 2 gånger.";

            // Act 
            string actual = sut.ToString();
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
