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
            driver.Manage().Window.Maximize();
            //2 Click on the Sards link
            driver.FindElement(By.CssSelector("a[href='/cards']")).Click();
            //3 Assert that Elixir Golem is displayed
            var ThreeMusketeers = driver.FindElement(By.CssSelector("a[href*='Three+Musketeers']"));
            Assert.That(ThreeMusketeers.Displayed);
        }


        [Test]
        public void ElixirGolemHeadersAreCorrectOnCardDetailsPage()
        {
            //1 Go to Stats Rolayle page
            driver.Url = "https://statsroyale.com/";
            driver.Manage().Window.Maximize();
            //2 Click on the Cards link
            driver.FindElement(By.CssSelector("a[href='/cards']")).Click();
            //3 Go to the Details page
            var ThreeMusketeers = driver.FindElement(By.CssSelector("a[href*='Three+Musketeers']"));
            //4 Assert basic header stats
            var CardName = driver.FindElement(By.CssSelector("[class*='cardName']")).Text;
            var CardCategories = driver.FindElement(By.CssSelector(".card__rarirty")).Text.Split(", ");
            var CardType = CardCategories[0];
            var CardArena = CardCategories[1];
            var CardRarirty = driver.FindElement(By.CssSelector(".card__rare")).Text;

            Assert.AreEqual("Three Musketeers", CardName);
            Assert.AreEqual("Troop", CardType);
            Assert.AreEqual("Arena 7", CardArena);
            Assert.AreEqual("Rare", CardRarirty);
        }
    }
}