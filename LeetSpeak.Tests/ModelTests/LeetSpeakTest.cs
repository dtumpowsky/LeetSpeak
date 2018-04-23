using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeakApp.Models;
using System.Collections.Generic;
using System;

namespace LeetSpeakApp.Tests
{
    [TestClass]
    public class LeetSpeakTests
    {

        [TestMethod]
        public void ChangeCharacter_ReturnEChange_String()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak("me");

            Assert.AreEqual("m3", testLeetSpeak.ChangeCharacter());
        }
        [TestMethod]
        public void ChangeCharacter_ReturnIChange_String()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak("if");

            Assert.AreEqual("1f", testLeetSpeak.ChangeCharacter());
        }
        [TestMethod]
        public void ChangeCharacter_ReturnOChange_String()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak("you");

            Assert.AreEqual("y0u", testLeetSpeak.ChangeCharacter());
        }

        [TestMethod]
        public void ChangeCharacter_ReturnTChange_String()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak("hello there");

            Assert.AreEqual("h3ll0 7h3r3", testLeetSpeak.ChangeCharacter());
        }


    }
}
