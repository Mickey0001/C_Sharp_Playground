using SeleniumExtras.PageObjects;

namespace AutomationPractice
{
    public static class Pages
    {
        private static T getPages() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browsers.getDriver, page);
            return page;
        }
        public static Home home
        {
            get { return getPages(); }
        }
    }
}