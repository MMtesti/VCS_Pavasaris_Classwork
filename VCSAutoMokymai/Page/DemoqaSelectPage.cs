﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace VCSAutoMokymai.Page
{
    class DemoqaSelectPage : BasePage
    {
        private const string PageAddress = "https://demoqa.com/select-menu";

        private static IWebElement _popup => Driver.FindElement(By.Id("close-fixedban"));
        private SelectElement _dropDown => new SelectElement(Driver.FindElement(By.Id("oldSelectMenu")));
        private SelectElement _multiDropDown => new SelectElement(Driver.FindElement(By.Id("cars")));

        public DemoqaSelectPage(IWebDriver webdriver) : base(webdriver) { }

        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;
        }

        public void ClosePopUp()
        {
            GetWait(10).Until(d => _popup.Displayed);
            _popup.Click();
        }

        public void SelectFromDropDownByText(string text)
        {
            _dropDown.SelectByText(text);
        }

        public void SelectFromDropDownByValue(string value)
        {
            _dropDown.SelectByValue(value);
        }

        public void VerifySingleSelectResult(string expectedResult)
        {
            Assert.AreEqual(expectedResult, _dropDown.SelectedOption.Text, "Fail. Selected color is incorect.");
        }

        public void SelectMultiDropDown(List<string> elements)
        {
            Actions action = new Actions(Driver);

            action.KeyDown(Keys.LeftControl);

            foreach (IWebElement selectElement in _multiDropDown.Options)
            {
                foreach (string element in elements)
                {
                    if (element.Equals(selectElement.Text))
                    {
                        _multiDropDown.SelectByText(element);
                    }
                }
            }

            action.KeyUp(Keys.LeftControl);
            action.Build().Perform();
        }

        public void VerifyMultiSelectDropDown(string expectedResult)
        {
            IList<IWebElement> options = _multiDropDown.AllSelectedOptions;

            foreach (IWebElement option in options)
            {
                Assert.IsTrue(expectedResult.Contains(option.Text), "Selected wrong car");
            }
        }
    }
}
