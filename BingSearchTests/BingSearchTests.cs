using NUnit.Framework;
using BingSearches;
using System.Threading;


namespace BingSearchTests
{
    [TestFixture]
    public class BingSearchTests
    {
        [Test]
        [TestCase("Dhoni", Category = "Edge")]
        [TestCase("Amy Adams", Category = "Edge")]
        [TestCase("Rinposhe Lama", Category = "Edge")]
        [TestCase("Mark Martin", Category = "Edge")]
        [TestCase("Bobby Flay", Category = "Edge")]
        [TestCase("Willard Scott", Category = "Edge")]
        [TestCase("William Penn", Category = "Edge")]
        [TestCase("Blake Lively", Category = "Edge")]
        [TestCase("Peyton Manning", Category = "Edge")]
        [TestCase("Joe Rogan", Category = "Edge")]
        [TestCase("Sri Lanka", Category = "Edge")]
        [TestCase("Washington", Category = "Edge")]
        [TestCase("Long Beach", Category = "Edge")]
        [TestCase("Peter Lugers", Category = "Edge")]
        [TestCase("Walter Scott", Category = "Edge")]
        [TestCase("King George", Category = "Edge")]
        [TestCase("Florida Keys", Category = "Edge")]
        [TestCase("Karnataka", Category = "Edge")]
        [TestCase("Warriors", Category = "Edge")]
        [TestCase("Jaylen Smith", Category = "Edge")]
        [TestCase("Home Depot", Category = "Edge")]
        [TestCase("Banfield Pet Hospital", Category = "Edge")]
        [TestCase("Pullman", Category = "Edge")]
        [TestCase("Hood River Oregon", Category = "Edge")]
        [TestCase("Bart Simpson", Category = "Edge")]
        [TestCase("Mark Spitz", Category = "Edge")]
        [TestCase("Hadrian", Category = "Edge")]
        [TestCase("Clytemnestra", Category = "Edge")]
        [TestCase("Wicked Witch of the West", Category = "Edge")]
        [TestCase("Julie Newmar", Category = "Edge")]
        [TestCase("Trajan", Category = "Edge")]
        [TestCase("Constantine", Category = "Edge")]
        [TestCase("Ellen", Category = "Edge")]
        [TestCase("Justin Bieber", Category = "Edge")]
        [TestCase("Elephant", Category = "Edge")]
        [TestCase("Giraffe", Category = "Edge")]


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

        private int _timeout = 1500;
        readonly BingSearchCommands _bingSearchCommands = new BingSearchCommands();
        readonly BingSearchPom _bingSearchPom = new BingSearchPom();

    }
}