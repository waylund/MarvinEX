using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarvinEX;

namespace MarvinEXTests
{
    [TestClass]
    public class MarvinUnitTests
    {
        [TestMethod]
        public void GenericStatementTest()
        {
            //Arrange
            Marvin marvin = new Marvin();

            //Act
            string response = marvin.talk("Hi there.");

            //Assert
            Assert.AreEqual("Whatever.", response);
        }

        [TestMethod]
        public void AskAQuestionTest()
        {
            Marvin marvin = new Marvin();
            string response = marvin.talk("How are you?");
            Assert.AreEqual("I don't care.", response);
        }

        [TestMethod]
        public void StayingQuietTest()
        {
            Marvin marvin = new Marvin();
            string response = marvin.talk(" ");
            Assert.AreEqual("Fine. Don't say anything.", response);
        }

        [TestMethod]
        public void StayingQuietEmptyStringTest()
        {
            Marvin marvin = new Marvin();
            string response = marvin.talk("");
            Assert.AreEqual("Fine. Don't say anything.", response);
        }

        [TestMethod]
        public void DontYellTest()
        {
            Marvin marvin = new Marvin();
            string response = marvin.talk("DON'T TOUCH THAT!");
            Assert.AreEqual("No need to yell. I'm right here.", response);
        }

        [TestMethod]
        public void YellingTrumpsQuestionTest()
        {
            Marvin marvin = new Marvin();
            string response = marvin.talk("WHAT IS IT MAN?");
            Assert.AreEqual("No need to yell. I'm right here.", response);
        }
    }
}
