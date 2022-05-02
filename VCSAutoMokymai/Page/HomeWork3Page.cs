using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSAutoMokymai.Page
{
    class HomeWork3Page : BasePage
    {
        private const string PageAddress = "https://demoqa.com/checkbox";

        private IWebElement _expandAllButton => Driver.FindElement(By.CssSelector("#tree-node > div > button.rct-option.rct-option-expand-all"));
        private IWebElement _expandCommands => Driver.FindElement(By.CssSelector("#tree-node > ol > li > ol > li:nth-child(1) > ol > li:nth-child(2) > span > label > span.rct-checkbox > svg > path"));
        private  IWebElement _popup => Driver.FindElement(By.Id("close-fixedban"));
        private static IWebElement _nameResult => Driver.FindElement(By.Id("name"));

        public HomeWork3Page(IWebDriver webDriver) : base(webDriver) { }

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
        public void ClickExpandCommands()
        {
            _expandCommands.Click();
        }
        public void VerifyCommandsResult(string expectedResult)
        {
            Assert.AreEqual($"You have selected:{expectedResult}", _nameResult.Text, "Name is wrong!");
        }
    }
}
