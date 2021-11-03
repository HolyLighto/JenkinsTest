using NUnit.Framework;

namespace JenkinsTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(1, 1, "Nums are not equal");
            Assert.AreEqual(0, 1, "Nums are not equal");
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(11, 11, "Test2 Nums are not equal");
        }
    }
}