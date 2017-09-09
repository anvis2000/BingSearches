using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;

namespace BingSearches
{

    public class BingSearchPom
    {
        //private readonly IWebDriver _driver;
        //[FindsBy(How = How.Id, Using = "sb_form_q")]
        //public IWebElement BingSearchBox;

        //[FindsBy(How = How.Id, Using = "sb_form_go")]
        //public IWebElement BingSearchSubmit;

        //public BingSearchPom(IWebDriver driver)
        //{
        //    _driver = driver;
        //    PageFactory.InitElements(_driver, this);
        //}
        public IWebElement BingSearchBox => Driver.driver.FindElement(By.Id("sb_form_q"));
        public IWebElement BingSearchSubmit => Driver.driver.FindElement(By.Id("sb_form_go"));
    }
}
