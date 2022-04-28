using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSAutoMokymai
{
    class HomeWork1Optimization
    {
        private static IWebDriver driver;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Url = "https://testpages.herokuapp.com/styled/calculator";
        }

        [TestCase("2", "2", "4",TestName = "2 + 2 = 4")]
        [TestCase("-5", "3", "-2", TestName = "-5 + 3 = -2")]
        [TestCase("A", "B", "ERR", TestName = "A + B = ERR")]
        
        public static void TestSum(string firstValue, string secondValue, string expectedResult)
        {
            IWebElement firstInput = driver.FindElement(By.Id("number1"));
            firstInput.Clear();
            firstInput.SendKeys(firstValue);

            IWebElement secondInput = driver.FindElement(By.Id("number2"));
            secondInput.Clear();
            secondInput.SendKeys(secondValue);

            IWebElement submitButton = driver.FindElement(By.Id("calculate"));
            submitButton.Click();

            IWebElement actualResult = driver.FindElement(By.Id("answer"));
            Assert.AreEqual(expectedResult, actualResult.Text, "Sum is wrong!");
            
        }
        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            driver.Quit();
        }

    }
}
