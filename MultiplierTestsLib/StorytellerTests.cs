using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiplierLib;

namespace MultiplierTestsLib
{
    [TestClass]
    public class StorytellerTests
    {
        [TestMethod]
        public void TellStoryToYoungAnnaiNotScary()
        {
            // Arrange
            var sut = new Storyteller();
            // Act
            var actual = sut.TellStory("Annai", 5, false);
            // Assert
            Assert.AreEqual("Lyssna nu Annai. Det var en gång en prinsessa " + "som tyckte om att dansa", actual);
        }
        [TestMethod]
        public void TellStoryToYoungAnnaiScary()
        {
            // Arrange
            var sut = new Storyteller();
            // Act
            var actual = sut.TellStory("Annai", 5, true);
            // Assert
            Assert.AreEqual("Lyssna nu Annai. Det var en gång en prinsessa " + "som egentligen var en varulv", actual);
        }
        [TestMethod]
        public void TellStoryToOldMarcoNotScary()
        {
            // Arrange
            var sut = new Storyteller();
            // Act
            var actual = sut.TellStory("Marco", 39, false);
            // Assert
            Assert.AreEqual("Hallå Marco! En gång fanns en kille " + "som tyckte om att dansa", actual);
        }
        [TestMethod]
        public void TellStoryToOldMarcoScary()
        {
            // Arrange
            var sut = new Storyteller();
            // Act
            var actual = sut.TellStory("Marco", 39, true);
            // Assert
            Assert.AreEqual("Hallå Marco! En gång fanns en kille " + "som egentligen var en varulv", actual);
        }
    }
}
