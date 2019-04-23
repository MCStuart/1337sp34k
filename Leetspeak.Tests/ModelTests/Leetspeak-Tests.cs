using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetspeak;

namespace Leetspeak.Tests
{
    [TestClass]
    public class LeetspeakTest
    {
        [TestMethod]
        public void IsLeetspeak_ContainE_True()
        {
            Leetspeak testLeetspeak = new Leetspeak();
            Assert.AreEqual("3", testLeetspeak.LeetspeakGenerator("e"));
        }
        [TestMethod]
        public void IsLeetspeak_ContainO_True()
        {
            Leetspeak testLeetspeak = new Leetspeak();
            Assert.AreEqual("0", testLeetspeak.LeetspeakGenerator("o"));
        }
        [TestMethod]
        public void IsLeetspeak_ContainI_True()
        {
            Leetspeak testLeetspeak = new Leetspeak();
            Assert.AreEqual("1", testLeetspeak.LeetspeakGenerator("I"));
        }
        [TestMethod]
        public void IsLeetspeak_ContainT_True()
        {
            Leetspeak testLeetspeak = new Leetspeak();
            Assert.AreEqual("7", testLeetspeak.LeetspeakGenerator("t"));
        }
        [TestMethod]
        public void IsLeetspeak_StartsWithS_True()
        {
            Leetspeak testLeetspeak = new Leetspeak();
            Assert.AreEqual("s", testLeetspeak.LeetspeakGenerator("string"));
        }
        [TestMethod]
        public void IsLeetspeak_SNotFirstLetter_True()
        {
            Leetspeak testLeetspeak = new Leetspeak();
            Assert.AreEqual("z", testLeetspeak.LeetspeakGenerator("sunshine"));
        }
    }
}
