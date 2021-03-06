using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BaseCode
{
    public class BaseTest
    {

        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
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

        [Test]
        public void TestZone()
        {
            Assert.True(true);
        }

        [Test]
        public void TestFailedZone()
        {
            Assert.False(true);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}