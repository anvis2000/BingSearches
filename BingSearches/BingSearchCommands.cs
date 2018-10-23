using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;

namespace BingSearches
{
	//Selenium commands to navigate Bing Searches
    public class BingSearchCommands
    {
        public void GoToBingPage()
        {
            var url = "http://www.bing.com";
            Driver.driver.Navigate().GoToUrl(url);
        }

        public void EnterBingSearchTerm(string term)
        {
            _bingSearchPom.BingSearchBox.SendKeys(term);
        }

        public void SubmitBingSearchTerm()
        {
            _bingSearchPom.BingSearchSubmit.Click();
        }

        public void HitEnterKeyOnSearchText()
        {
            Driver.driver.FindElement(By.Id("sb_form_q")).SendKeys(Keys.Enter);
        }


        private readonly BingSearchPom _bingSearchPom = new BingSearchPom();
    }
}
