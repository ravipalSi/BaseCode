using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BaseCode
{
    public class BaseTest
    {
        [SetUp]
        public void Setup()
        {
            IWebDriver driver = new ChromeDriver();
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
    }
}