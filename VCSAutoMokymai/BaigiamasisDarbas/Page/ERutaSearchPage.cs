using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace VCSAutoMokymai.BaigiamasisDarbas.Page
{
    class ERutaSearchPage : BasePage
    {
        private const string PageAddress = "https://www.e-ruta.lt/paieska";

        
        private IWebElement _searchInput => Driver.FindElement(By.CssSelector("#main-search-input")); // CssSelector "#main-search-input" ar Id("main-search-input")

        private IWebElement _searchSubmitButton => Driver.FindElement(By.Id("main-search-submit"));

        private IWebElement _searchActualResult => Driver.FindElement(By.CssSelector("#middle_blocks > li > h2 > span:nth-child(1)"));

        private IReadOnlyCollection<IWebElement> searchResults = Driver.FindElements(By.ClassName("item-info-container"));

        public ERutaSearchPage(IWebDriver webDriver) : base(webDriver) { }

        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;
        }
        public void InsertTextToSerchField(string searchText)
        {
            _searchInput.SendKeys(searchText);
        }
        public void ClickSearchSubmitButton()
        {
            _searchSubmitButton.Click();
        }
        public void VerifySearchResult(string expectedResult)
        {
            Assert.AreEqual(expectedResult, _searchActualResult.Text, "Name is wrong!");
        }
    }
}
