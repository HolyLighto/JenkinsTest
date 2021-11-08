using Aquality.Selenium.Browsers;
using NUnit.Framework;

namespace JenkinsTest
{
    public class Tests
    {
        private Browser _browser;
        [SetUp]
        public void Setup()
        {
            _browser = AqualityServices.Browser;
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(1, 1, "Nums are not equal");
            Assert.AreEqual(10, 11, "Nums are not equal");
        }
    }
}