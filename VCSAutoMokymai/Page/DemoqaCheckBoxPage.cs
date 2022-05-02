using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
namespace VCSAutoMokymai.Page
{
    class DemoqaCheckBoxPage :BasePage
        

    {
        private const string PageAddress = "https://demoqa.com/checkbox";

        private IWebElement _expandAllButton => Driver.FindElement(By.CssSelector("#tree-node > div > button.rct-option.rct-option-expand-all"));

        private static IWebElement _popup => Driver.FindElement(By.Id("close-fixedban"));

        public DemoqaCheckBoxPage(IWebDriver webDriver) : base(webDriver) { }

        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;
        }

        public void ClosePopUp()
        {
            GetWait(10).Until(d => _popup.Displayed);
            _popup.Click();
        }

        public void ClickExpandAllButton()
        {
            _expandAllButton.Click();
        }
    }
}
