using OpenQA.Selenium;

namespace Royale.Pages

{
    public class CardsPage : PageBase
    {
        public readonly CardsPageMap Map;

        public CardsPage(IWebDriver driver) : base(driver)
        {
            Map = new CardsPageMap(driver);
        }
        public CardsPage GoTo()
        {
            HeaderNav.GotoCardsPage();
            return this;
        }
        public IWebElement GetCardByName(string cardName)
        {
            if (cardName.Contains(" "))
            {
                cardName.Replace(" ", "+");
            }
            return Map.Card(cardName);
        }
    }

    public class CardsPageMap
    {
        IWebDriver _driver;

        public CardsPageMap(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement Card(string name) => _driver.FindElement(By.CssSelector($"a[href*='{name}']"));
    }

}

//14:56