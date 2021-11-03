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
            Assert.AreEqual(1,1, "Nums are not equals");
            Assert.AreEqual(0, 1);
        }
    }
}