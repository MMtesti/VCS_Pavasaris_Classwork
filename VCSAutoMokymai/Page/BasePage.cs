using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace VCSAutoMokymai.Page
{
    class BasePage
    {
        protected static IWebDriver Driver;

        public BasePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public WebDriverWait GetWait(int seconds = 5)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(seconds));

            return wait;
        }
    }
}
