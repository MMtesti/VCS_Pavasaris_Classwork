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
    class DemoqaTestBoxTest
    {
        private static IWebDriver _driver;
        [OneTimeSetUp]
        public static void OneTimeSetup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
        }
        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            _driver.Quit();
        }
        [Test]
        public  static void TestFullNameInputField()
        {
            string fullName = "Milda";
            DemoqaTestBoxPage demoqaTestBoxPage = new DemoqaTestBoxPage(_driver);
            demoqaTestBoxPage.NavigateToDefoultPage();
            demoqaTestBoxPage.InsertTextToFullNameField(fullName);
            demoqaTestBoxPage.ClickSubmitButton();
            demoqaTestBoxPage.VerifyFullNameResult(fullName);
        }
    }
}
