using NUnit.Framework;

namespace BaseCode
{
    public class BaseTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestLogin()
        {
            Assert.Pass();
        }

        [Test]
        public void TestFail()
        {
            Assert.Fail();
        }
    }
}