using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCSAutoMokymai.Page;

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
            Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Manage().Window.Maximize();

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
    }
}
