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
    class HomeWork2Optional
    {
        [Test]
        public static void TestRunningCalculator()
        {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        driver.Manage().Window.Maximize();
        driver.Url = "https://www.active.com/fitness/calculators/pace";
        IWebElement timeHour = driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(2) > div > label:nth-child(1) > input[type=number]"));
        string hour = "1";
        timeHour.SendKeys(hour);
        IWebElement timeMin = driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(2) > div > label:nth-child(2) > input[type=number]"));
        string min = "5";
        timeMin.SendKeys(min);
        IWebElement distance = driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(3) > div > label > input[type=number]"));
        string distanceValue = "13";
        distance.SendKeys(distanceValue);
        IWebElement selectBoxitContaner = driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(3) > div > span > span > span.selectboxit-arrow-container"));
        selectBoxitContaner.Click();

        }

    }
}
