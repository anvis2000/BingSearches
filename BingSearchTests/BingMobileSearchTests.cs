using NUnit.Framework;
using BingSearches;
using System.Threading;

namespace BingSearchTests
{
    [TestFixture]
    public class BingMobileSearchTests
    {
        [Test]
        [TestCase("Virat Kohli", Category = "Chrome")]
        [TestCase("Amy Schumer", Category = "Chrome")]
        [TestCase("Dalai Lama", Category = "Chrome")]
        [TestCase("Mark Wahlberg", Category = "Chrome")]
        [TestCase("Masaharu Morimoto", Category = "Chrome")]
        [TestCase("Elvis", Category = "Chrome")]
        [TestCase("Will I Am", Category = "Chrome")]
        [TestCase("Jennifer Lawrence", Category = "Chrome")]
        [TestCase("Tom Brady", Category = "Chrome")]
        [TestCase("Phil Collins", Category = "Chrome")]
        [TestCase("India", Category = "Chrome")]
        [TestCase("Oregon", Category = "Chrome")]
        [TestCase("Cannon Beach", Category = "Chrome")]
        [TestCase("Peter Parker", Category = "Chrome")]
        [TestCase("Wolverine", Category = "Chrome")]
        [TestCase("Jennifer Lopez", Category = "Chrome")]
        [TestCase("Catalina", Category = "Chrome")]
        [TestCase("Tamil Nadu", Category = "Chrome")]
        [TestCase("Wombat", Category = "Chrome")]
        [TestCase("Jennifer Rodriguez", Category = "Chrome")]
        [TestCase("Emma Stone", Category = "Chrome")]
        [TestCase("Henry Cavill", Category = "Chrome")]
        [TestCase("Widget", Category = "Chrome")]
        [TestCase("Marcus Mariota", Category = "Chrome")]
        [TestCase("Gary Anderson", Category = "Chrome")]
        [TestCase("Brian Cheesman", Category = "Chrome")]

        public void CanDoAMobileBingSearch(string searchTerm)
        {
            _bingSearchPom.BingSearchBox.Click();
            _bingSearchPom.BingSearchBox.Clear();
            _bingSearchCommands.EnterBingSearchTerm(searchTerm);
            _bingSearchCommands.HitEnterKeyOnSearchText();
            Thread.Sleep(_timeout);
        }


        [OneTimeSetUp]
        public void TestFixtureInitialize()
        {
            Driver.InitializeBrowser(Driver.BrowserType.ChromeMobile);
            _bingSearchCommands.GoToBingPage();
        }

        [OneTimeTearDown]
        public void TestTearDown()
        {
            Driver.driver.Quit();
            Driver.driver.Dispose();
        }

        private int _timeout = 4000;
        readonly BingSearchCommands _bingSearchCommands = new BingSearchCommands();
        readonly BingSearchPom _bingSearchPom = new BingSearchPom();

    }
}