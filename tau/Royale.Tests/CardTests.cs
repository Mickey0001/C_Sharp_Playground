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
        public void ElixirGolemIsOnTheCardsPage()
        {
           //1 Go to Stats Rolayle page
            driver.Url = "https://statsroyale.com/";
           //2 Click on the Sards link
           driver.FindElement(By.CssSelector("a[href='/cards']")).Click();
           //Assert that Elixir Golem is displayed
           var ElixirGolem = driver.FindElement(By.CssSelector("a[href*='Elixir+Golem']"));
           Assert.That(ElixirGolem.Displayed);
        }

        
        [Test]
        public void ElixirGolemHeadersAreCorrectOnCardDetailsPage()
        {
           //1 Go to Stats Rolayle page
            driver.Url = "https://statsroyale.com/";
           //2 Click on the Cards link
           driver.FindElement(By.CssSelector("a[href='/cards']")).Click();
           //3 Go to the Details page
           driver.FindElement(By.CssSelector("a[href*='Elixir+Golem']")).Click();
           //4 Assert basic header stats
           var CardName = driver.FindElement(By.CssSelector("[class*='cardName']"));
           
        }
    }
}