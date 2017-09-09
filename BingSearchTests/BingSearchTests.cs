using NUnit.Framework;
using BingSearches;
using System.Threading;


namespace BingSearchTests
{
    [TestFixture]
    public class BingSearchTests
    {
        [Test]
        [TestCase("Virat Kohli", Category = "Edge")]
        [TestCase("Amy Schumer", Category = "Edge")]
        [TestCase("Dalai Lama", Category = "Edge")]
        [TestCase("Mark Wahlberg", Category = "Edge")]
        [TestCase("Masaharu Morimoto", Category = "Edge")]
        [TestCase("Elvis", Category = "Edge")]
        [TestCase("Will I Am", Category = "Edge")]
        [TestCase("Jennifer Lawrence", Category = "Edge")]
        [TestCase("Tom Brady", Category = "Edge")]
        [TestCase("Phil Collins", Category = "Edge")]
        [TestCase("India", Category = "Edge")]
        [TestCase("Oregon", Category = "Edge")]
        [TestCase("Cannon Beach", Category = "Edge")]
        [TestCase("Peter Parker", Category = "Edge")]
        [TestCase("Wolverine", Category = "Edge")]
        [TestCase("Jennifer Lopez", Category = "Edge")]
        [TestCase("Catalina", Category = "Edge")]
        [TestCase("Tamil Nadu", Category = "Edge")]
        [TestCase("Wombat", Category = "Edge")]
        [TestCase("Jennifer Rodriguez", Category = "Edge")]
        [TestCase("Sri Lanka", Category = "Edge")]
        [TestCase("Washington", Category = "Edge")]
        [TestCase("Puyallup", Category = "Edge")]
        [TestCase("Bend Oregon", Category = "Edge")]
        [TestCase("Bethany", Category = "Edge")]
        [TestCase("Mark Anthony", Category = "Edge")]
        [TestCase("Octavian", Category = "Edge")]
        [TestCase("Cleopatra", Category = "Edge")]
        [TestCase("Wicked Cupcakes", Category = "Edge")]
        [TestCase("Jennifer Jones", Category = "Edge")]
        public void CanDoABingSearch(string searchTerm)
        {
            _bingSearchPom.BingSearchBox.Clear();
            _bingSearchCommands.EnterBingSearchTerm(searchTerm);
            _bingSearchCommands.SubmitBingSearchTerm();
            Thread.Sleep(_timeout);
        }

        [OneTimeSetUp]
        public void TestFixtureInitialize()
        {
            Driver.InitializeBrowser(Driver.BrowserType.Edge);
            _bingSearchCommands.GoToBingPage();

        }

        [OneTimeTearDown]
        public void TestFixtureTearDown()
        {
            Driver.driver.Quit();
            Driver.driver.Dispose();
        }

        private int _timeout = 2000;
        readonly BingSearchCommands _bingSearchCommands = new BingSearchCommands();
        readonly BingSearchPom _bingSearchPom = new BingSearchPom();

    }
}