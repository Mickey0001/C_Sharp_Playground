using AutomationPractice;
using SeleniumExtras.PageObjects;

namespace SeleniumProject
{
    public static class Pages
    {
        private static T getPages() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(WebDriverFacade.getDriver, page);
            return page;
        }
        public static Home home
        {
            get { return getPages(); }
        }
    }
}