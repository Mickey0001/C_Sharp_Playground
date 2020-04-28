using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Royale.Pages;

namespace Royale.Tests
{
    public class CardTests
    {
        IWebDriver driver;

        [SetUp]
        public void BeforeEachTest()
        {
            driver = new ChromeDriver(Path.GetFullPath(@"../../../../" + "_drivers"));
            driver.Url = "https://statsroyale.com";
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void AfterEachTest()
        {
            driver.Quit();
        }

        [Test]
        public void ThreeMusketeersIsOnTheCardsPage()
        {

            var cardsPage = new CardsPage(driver);
            var threeMusketeers = cardsPage.GoTo().GetCardByName("Three Musketeers");
            Assert.That(threeMusketeers.Displayed);
        }


        [Test]
        public void ThreeMusketeerAreCorrectOnCardDetailsPage()
        {
            new CardsPage(driver).GoTo().GetCardByName("Ice Sprit").Click();
            var cardDetails = new CardsPage(driver);

            var (category, arena) = cardDetails.GetCardCategory();
            var CardName = cardDetails.Map.CardName.Text;
            var CardRarirty = cardDetails.Map.CardRarirty.Text;

            Assert.AreEqual("Three Musketeers", CardName);
            Assert.AreEqual("Troop", category);
            Assert.AreEqual("Arena 7", arena);
            Assert.AreEqual("Rare", CardRarirty);
        }

        
        [Test]
        public void MirrorAreCorrectOnCardDetailsPage()
        {
            new CardsPage(driver).GoTo().GetCardByName("Mirror").Click();
            var cardDetails = new CardsPage(driver);
            
            var (category, arena) = cardDetails.GetCardCategory();
            var CardName = cardDetails.Map.CardName.Text;
            var CardRarirty = cardDetails.Map.CardRarirty.Text;

            Assert.AreEqual("Mirror", CardName);
            Assert.AreEqual("Spell", category);
            Assert.AreEqual("Arena 12", arena);
            Assert.AreEqual("Epic", CardRarirty);
        }
    }
}