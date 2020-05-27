using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void VerifyHeaderText()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://mirzasisic.com/");
            IWebElement HeaderText = driver.FindElement(By.TagName("h1"));
            HeaderText.Equals("Mirza Šišić");
            driver.Close();
        }
    }
}