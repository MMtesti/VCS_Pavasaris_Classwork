using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSAutoMokymai
{
    class testCheckBox
    {

        private static IWebDriver driver;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/checkbox";
        }

        [Test]
        public static void ClickOnCheckBoxes()
        {
            IWebElement expandAllButton = driver.FindElement(By.CssSelector("#tree-node > div > button.rct-option.rct-option-expand-all"));
            expandAllButton.Click();

            IReadOnlyCollection<IWebElement> checkBoxes = driver.FindElements(By.ClassName("rct-checkbox"));

            foreach (IWebElement checkBox in checkBoxes)
            {
                checkBox.Click();
            }

            for (int i = 0; i < checkBoxes.Count; i++)
            {
                checkBoxes.ElementAt(i).Click();
            }
        }


    }
}
