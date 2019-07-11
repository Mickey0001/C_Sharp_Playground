using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomationPractice
{
    public class Home
    {
        //Locators
        [FindsBy(How = How.CssSelector, Using = "#small-searchterms")]
        private IWebElement SearchStoreInput;

        [FindsBy(How = How.XPath, Using = "//input[@value='Search']")]
        private IWebElement SearchButton;

        //Actions
        public void isAt()
        {
            Assert.IsTrue(Browsers.Title.Equals("nopCommerce demo store"));
        }
        public void EnterSearchText(string searchText)
        {
            Assert.IsTrue(SearchStoreInput.Displayed);
            SearchStoreInput.SendKeys(searchText);
        }
    }
}