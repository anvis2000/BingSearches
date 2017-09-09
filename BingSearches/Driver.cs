using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.PhantomJS;

namespace BingSearches
{
    public class Driver
    {
        public static IWebDriver driver { get; set; }
        public static int TimeOutInSec { get; set; } = 10;
        public enum BrowserType
        {
            Chrome,
            ChromeMobile,
            ChromeHeadless,
            Firefox,
            InternetExplorer,
            Edge,
            PhantomJs
        }

        public enum BrowserSize
        {
            Desktop,
            Tablet,
            Phone
        }


        public static void InitializeBrowser(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    driver = new ChromeDriver();
                    break;

                case BrowserType.ChromeMobile:
                    ChromeOptions chromeOptions = new ChromeOptions();
                    chromeOptions.AddArgument("user-data-dir=C:/Users/Annamalai/AppData/Local/Google/Chrome/User Data");
                    chromeOptions.EnableMobileEmulation("iPhone 6");
                    driver = new ChromeDriver(chromeOptions);
                    break;

                case BrowserType.ChromeHeadless:
                    ChromeOptions chromeOpt = new ChromeOptions();
                    chromeOpt.AddArguments("user-data-dir=C:/Users/Annamalai/AppData/Local/Google/Chrome/User Data");
                    chromeOpt.AddArguments("--headless");
                    chromeOpt.AddArguments("--disable-gpu");
                    driver = new ChromeDriver(chromeOpt);
                    break;

                case BrowserType.Firefox:
                    driver = new FirefoxDriver();
                    break;

                case BrowserType.InternetExplorer:
                    driver = new InternetExplorerDriver();
                    break;

                case BrowserType.Edge:
                    driver = new EdgeDriver();
                    break;

                case BrowserType.PhantomJs:
                    driver = new PhantomJSDriver();
                    break;
            }

        }

        public static void SetBrowserSize(BrowserSize size)
        {
            switch (size)
            {
                case BrowserSize.Desktop:
                    driver.Manage().Window.Maximize();
                    break;
                case BrowserSize.Tablet:
                    driver.Manage().Window.Size = new Size(768, 800);
                    break;
                case BrowserSize.Phone:
                    driver.Manage().Window.Size = new Size(320, 480);
                    break;
            }

        }
    }
}