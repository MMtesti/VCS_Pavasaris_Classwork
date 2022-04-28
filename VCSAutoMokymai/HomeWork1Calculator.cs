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
    class HomeWork1Calculator
    {
        [Test]
        public static void TestCalculatorSumA()
        {
            //  2+2
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://testpages.herokuapp.com/styled/calculator";

            IWebElement firstInput = driver.FindElement(By.Id("number1"));
            int first = 2;
            firstInput.SendKeys(Convert.ToString(first));
            IWebElement functionSelection = driver.FindElement(By.Id("function"));
            functionSelection.SendKeys("plus");
            IWebElement secondInput = driver.FindElement(By.Id("number2"));
            int second = 2;
            secondInput.SendKeys(Convert.ToString(second));
            IWebElement submitButton = driver.FindElement(By.Id("calculate"));
            submitButton.Click();
            IWebElement CalculationResult = driver.FindElement(By.CssSelector("body > div > div.centered > div > p"));
            int expectedResult = first + second;
            Assert.AreEqual($"Answer : {expectedResult}", CalculationResult.Text, "Error.Bad calculation");
            driver.Quit();
        }
        [Test]
        public static void TestCalculatorSumB()
        {   
            // -5 + 3
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://testpages.herokuapp.com/styled/calculator";

            IWebElement firstInput = driver.FindElement(By.Id("number1"));
            int first = -5;
            firstInput.SendKeys(Convert.ToString(first));
            IWebElement functionSelection = driver.FindElement(By.Id("function"));
            functionSelection.SendKeys("plus");
            IWebElement secondInput = driver.FindElement(By.Id("number2"));
            int second = 3;
            secondInput.SendKeys(Convert.ToString(second));
            IWebElement submitButton = driver.FindElement(By.Id("calculate"));
            submitButton.Click();
            IWebElement CalculationResult = driver.FindElement(By.CssSelector("body > div > div.centered > div > p"));
            int expectedResult = first + second;
            Assert.AreEqual($"Answer : {expectedResult}", CalculationResult.Text, "Error.Bad calculation");
            driver.Quit();
        }
        [Test]
        public static void TestCalculatorSumC()
        {
            // a + b
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://testpages.herokuapp.com/styled/calculator";

            IWebElement firstInput = driver.FindElement(By.Id("number1"));
            string first = "a";
            firstInput.SendKeys(first);
            IWebElement functionSelection = driver.FindElement(By.Id("function"));
            functionSelection.SendKeys("plus");
            IWebElement secondInput = driver.FindElement(By.Id("number2"));
            string second = "b";
            secondInput.SendKeys(second);
            IWebElement submitButton = driver.FindElement(By.Id("calculate"));
            submitButton.Click();
            IWebElement CalculationResult = driver.FindElement(By.CssSelector("body > div > div.centered > div > p"));
            Assert.AreEqual($"Answer : ERR", CalculationResult.Text, "Error.Bad calculation");
            driver.Quit();
        }
    }


    
}
