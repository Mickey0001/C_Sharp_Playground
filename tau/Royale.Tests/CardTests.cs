using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Royale.Tests
{
    public class CardTests
    {
        IWebDriver driver;

        [SetUp]
        public void BeforeEachTest()
        {
            driver = new ChromeDriver(Path.GetFullPath(@"../../../../" + "_drivers"));
        }

        [TearDown]
        public void AfterEachTest()
        {
            driver.Quit();
        }

        [Test]
        public void IceSpiritIsOnTheCardsPage()
        {
            Assert.Pass();
        }
    }
}