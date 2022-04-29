﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSAutoMokymai
{
    class DemoQATestBoxTest
    {
        [Test]
        public static void TestInputPage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/text-box";

            IWebElement popup = driver.FindElement(By.Id("close-fixedban"));
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => popup.Displayed);
            popup.Click();

            IWebElement fullNameInput = driver.FindElement(By.Id("userName"));
            string fullName = "Milda M";
            fullNameInput.SendKeys(fullName);
           

            IWebElement submitButton = driver.FindElement(By.Id("submit"));
            submitButton.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement nameResult = driver.FindElement(By.Id("name"));
            Assert.AreEqual($"Name:{fullName}", nameResult.Text, "Name is wrong");
            driver.Quit();
        }
    }
}
