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
    }
}
