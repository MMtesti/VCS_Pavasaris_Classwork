using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using VCSAutoMokymai.Drivers;
using VCSAutoMokymai.Page;
using VCSAutoMokymai.Tools;

namespace VCSAutoMokymai.Test
{
    class BaseTest
    {
        protected static IWebDriver Driver;

        public static DemoqaTestBoxPage _demoqaTestBoxPage;
        public static DemoqaCheckBoxPage _demoqaCheckBoxPage;
        public static DemoqaSelectPage _demoqaSelectPage;
        public static HomeWork3Page _homeWork3Page;


        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            Driver = CustomDriver.GetChromeDriver();

            _demoqaTestBoxPage = new DemoqaTestBoxPage(Driver);
            _demoqaCheckBoxPage = new DemoqaCheckBoxPage(Driver);
            _demoqaSelectPage = new DemoqaSelectPage(Driver);
            _homeWork3Page = new HomeWork3Page(Driver);
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
           Driver.Quit();
        }
        [TearDown]
        public static void TearDown()
        {
            if(TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                MakeScreenshot.TakeScreenshot(Driver);
            }
        }
    }
}
