using NUnit.Framework;

namespace JenkinsTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        public void Test1()
        {
            Assert.AreEqual(1, 1, "Nums are not equal");
        }
    }
}