using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSAutoMokymai.BaigiamasisDarbas.Page
{
    class ERutaSearchPage : BasePage
    {
        private const string PageAddress = "https://www.e-ruta.lt/paieska";

        
        private static IWebElement _searchInput = Driver.FindElement(By.Id("main-search-input"));

        private static IWebElement _searchSubmitButton = Driver.FindElement(By.Id("main-search-submit"));

        public ERutaSearchPage(IWebDriver webdriver) : base(webdriver) { }

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
    }
}
