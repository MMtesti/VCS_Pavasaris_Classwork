using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSAutoMokymai.Page
{
    class AlertPage :BasePage
    {
        private const string PageAddress = "https://demoqa.com/alerts";
        private const string YouselectedText = "You selected";
        private const String YouEnteredText = "You entered";

        public AlertPage(IWebDriver webDriver) : base(webDriver) { }
        private IWebElement _firstAlertButton => Driver.FindElement(By.Id("alertButton"));
        private IWebElement _confirmButton => Driver.FindElement(By.Id("confirmButton"));
        private IWebElement _confirmResult => Driver.FindElement(By.Id("confirmResult"));
        private IWebElement _promptBoxButton => Driver.FindElement(By.Id("promtButton"));
        private IWebElement _promtResult => Driver.FindElement(By.Id("promtResult"));

        public AlertPage NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;
            return this;
        }
        public AlertPage ClickFirstAlertButton()
        {
            _firstAlertButton.Click();
            return this;
        }
        public AlertPage AcceptFirstAlert()
        {
            IAlert alert = Driver.SwitchTo().Alert();
            alert.Accept();
            return this;
        }
        public AlertPage ClickSecondAlertButton()
        {
            _confirmButton.Click();
            return this;
        }
        public AlertPage CancelSecondAlertButton()
        {
            Driver.SwitchTo().Alert().Dismiss();
            return this;
        }
        public AlertPage VerifySecondAlertText(string text)
        {
            Assert.AreEqual($"{YouselectedText} {text}", _confirmResult.Text, "Expected vc actual is not equals");
            return this;
        }

    }
}
