using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationPractice
{
    public static class WebDriverFacade
    {
        private static IWebDriver webDriver;
        public static IWebDriver WebDriver
        {
            get
            {
                if (webDriver == null)
                {
                    webDriver = new ChromeDriver();
                }
                return webDriver;
            }
        }

        private static string baseURL = "https://demo.nopcommerce.com/";
        private static string browser = "Chrome";
        public static void Init()
        {
            switch (browser)
            {
                case "Chrome":
                    webDriver = new ChromeDriver();
                    break;
                case "Firefox":
                    webDriver = new FirefoxDriver();
                    break;
                default:
                    webDriver = new ChromeDriver();
                    break;
            }
            webDriver.Manage().Window.Maximize();
            Console.WriteLine(string.Format("[{0}] - Web browser started", DateTime.Now.ToString("HH:mm:ss.fff")));
            Goto(baseURL);
            Console.WriteLine(string.Format("[{0}] - Url [{1}] initiated", DateTime.Now.ToString("HH:mm:ss.fff"), baseURL));
        }
        public static string Title
        {
            get { return webDriver.Title; }
        }
        public static IWebDriver getDriver
        {
            get { return webDriver; }
        }
        public static void Goto(string url)
        {
            webDriver.Url = url;
        }
        public static void Close()
        {
            webDriver.Quit();
        }

        //extensions
        public static bool ControlExists(this IWebDriver driver, By by)
        {
            return driver.FindElements(by).Count == 0 ? false : true;
        }

        public static bool ControlDisplayed(this IWebElement element, bool displayed = true, uint timeoutInSeconds = 60)
        {
            var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.IgnoreExceptionTypes(typeof(Exception));
            return wait.Until(drv =>
            {
                if (!displayed && !element.Displayed || displayed && element.Displayed)
                {
                    return true;
                }
                return false;
            });
        }

        public static IWebElement IsElementExists(this By Locator, uint timeoutInSeconds = 60)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(Locator));
            }
            catch
            {
                return null;
            }
        }

        public static bool ElementlIsClickable(this IWebElement element, uint timeoutInSeconds = 60, bool displayed = true)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv =>
                {
                    if (SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element) != null)
                        return true;

                    return false;
                });
            }
            catch
            {
                return false;
            }
        }

        public static void ClickWrapper(this IWebElement element, string elementName)
        {
            if (element.ElementlIsClickable())
            {
                element.Click();
            }
            else
            {
                throw new Exception(string.Format("[{0}] - Element [{1}] is not displayed", DateTime.Now.ToString("HH:mm:ss.fff"), elementName));
            }
        }

        public static void SendKeysWrapper(this IWebElement element, string value, string elementName)
        {
            Console.WriteLine(string.Format("[{0}] - SendKeys value [{1}] to  element [{2}]", DateTime.Now.ToString("HH:mm:ss.fff"), value, elementName));
            element.SendKeys(value);
        }

        public static void DoubleClickActionWrapper(this IWebElement element, string elementName)
        {
            Actions ClickButton = new Actions(webDriver);
            ClickButton.MoveToElement(element).DoubleClick().Build().Perform();
            Console.WriteLine("[{0}] - Double Click on element [{1}]", DateTime.Now.ToString("HH:mm:ss.fff"), elementName);
        }

        public static void ClearWrapper(this IWebElement element, string elementName)
        {
            Console.WriteLine("[{0}] - Clear element [{1}] content", DateTime.Now.ToString("HH:mm:ss.fff"), elementName);
            element.Clear();
            Assert.AreEqual(element.Text, string.Empty, "Element is not cleared");
        }

        public static void CheckboxWrapper(this IWebElement element, bool value, string elementName)
        {
            Console.WriteLine("[{0}] - Set value of checkbox [{1}] to [{2}]", DateTime.Now.ToString("HH:mm:ss.fff"), elementName, value.ToString());

            if ((!element.Selected && value == true) || (element.Selected && value == false))
            {
                element.Click();
            }
        }

    }
}