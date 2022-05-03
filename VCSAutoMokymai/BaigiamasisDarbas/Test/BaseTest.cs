using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCSAutoMokymai.BaigiamasisDarbas.Page;

namespace VCSAutoMokymai.BaigiamasisDarbas.Test
{
    class BaseTest
    {
        protected static IWebDriver Driver;

        public static ERutaPage _eRutaPage;
        public static ERutaSearchPage _eRutaSearchPage;
        // public static DemoqaSelectPage _demoqaSelectPage;



        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Manage().Window.Maximize();

           _eRutaPage = new ERutaPage(Driver);
           _eRutaSearchPage = new ERutaSearchPage(Driver);
          //  _demoqaCheckBoxPage = new DemoqaCheckBoxPage(Driver);
          

        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
          Driver.Quit();
        }
    }
}
