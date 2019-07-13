using NUnit.Framework;
using SeleniumProject;

namespace AutomationPractice
{
    [TestFixture]
    public class MyFirstPOMTest
    {
        [SetUp]
        public void StartUpTest()
        {
            WebDriverFacade.Init();
        }

        [TearDown]
        public void EndTest()
        {
            WebDriverFacade.Close();
        }

        [Test]
        public void MirzloWorldTest()
        {
            Pages.home.isAt();
            Pages.home.EnterSearchText("Mirzlo World!");
        }
    }
}