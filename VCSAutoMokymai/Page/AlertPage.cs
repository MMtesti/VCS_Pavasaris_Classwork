﻿using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSAutoMokymai.Page
{
    class AlertPage : BasePage
    {
        private const string PageAddress = "https://demoqa.com/alerts";
        private const string YouSelectedText = "You selected";
        private const string YouEnteredText = "You entered";

        private IWebElement _firstAlertButton => Driver.FindElement(By.Id("alertButton"));
        private IWebElement _confirmButton => Driver.FindElement(By.Id("confirmButton"));
        private IWebElement _confirmResult => Driver.FindElement(By.Id("confirmResult"));
        private IWebElement _promtBoxButton => Driver.FindElement(By.Id("promtButton"));
        private IWebElement _promtResult => Driver.FindElement(By.Id("promptResult"));


        public AlertPage(IWebDriver webDriver) : base(webDriver) { }

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
            Assert.AreEqual($"{YouSelectedText} {text}", _confirmResult.Text, "Expected vs actual result is incorect");

            return this;
        }

    }
}
