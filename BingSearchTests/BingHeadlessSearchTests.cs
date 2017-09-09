using NUnit.Framework;
using BingSearches;

namespace BingSearchTests
{
    class BingHeadlessSearchTests
    {
        [Test]
        [TestCase("Sunil Gavaskar", Category = "Headless")]
        [TestCase("Akshay Kumar", Category = "Headless")]
        [TestCase("Morgan Freeman", Category = "Headless")]
        [TestCase("Will Ferell", Category = "Headless")]
        [TestCase("Cindy Lauper", Category = "Headless")]
        [TestCase("Mick Jagger", Category = "Headless")]
        [TestCase("Paul Rodriguez", Category = "Headless")]
        [TestCase("Marco Rubio", Category = "Headless")]
        [TestCase("Suzanne Bonamici", Category = "Headless")]
        [TestCase("Art Garfunkel", Category = "Headless")]


        public void CanDoAHeadlessChromeSearch(string searchTerm)
        {
            _bingSearchPom.BingSearchBox.Click();
            _bingSearchPom.BingSearchBox.Clear();
            _bingSearchCommands.EnterBingSearchTerm(searchTerm);
            _bingSearchCommands.HitEnterKeyOnSearchText();
        }


        [SetUp]
        public void TestInitialize()
        {
            Driver.InitializeBrowser(Driver.BrowserType.ChromeHeadless);
            _bingSearchCommands.GoToBingPage();
        }

        [TearDown]
        public void TestTearDown()
        {
            Driver.driver.Quit();
            Driver.driver.Dispose();
        }

        readonly BingSearchCommands _bingSearchCommands = new BingSearchCommands();
        readonly BingSearchPom _bingSearchPom = new BingSearchPom();

    }
}
