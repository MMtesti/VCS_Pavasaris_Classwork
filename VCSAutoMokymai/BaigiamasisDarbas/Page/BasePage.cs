using OpenQA.Selenium;

namespace VCSAutoMokymai.BaigiamasisDarbas.Page
{
    class BasePage
    {
        protected static IWebDriver Driver;

        public BasePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

    }
}
