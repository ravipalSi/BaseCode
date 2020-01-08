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
            driver.Navigate().GoToUrl();
        }

        [Test]
        public void TestLogin()
        {
            Assert.Pass();
        }
    }
}