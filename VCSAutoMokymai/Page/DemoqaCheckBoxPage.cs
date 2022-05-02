using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace VCSAutoMokymai.Page
{
    class DemoqaCheckBoxPage
    {
        private static IWebDriver _driver;
        private static IWebElement _expandAllButton => _driver.FindElement(By.CssSelector("#tree-node > div > button.rct-option.rct-option-expand-all"));
        private static IReadOnlyCollection<IWebElement> _checkBoxes => _driver.FindElements(By.ClassName("rct-checkbox"));
        private static IReadOnlyCollection<IWebElement> _title => _driver.FindElements(By.ClassName("rct-title"));
        private static IWebElement _popup => _driver.FindElement(By.Id("close-fixedban"));
        public DemoqaCheckBoxPage(IWebDriver webDriver)
        {
            _driver = webDriver;
        }
        public void NavigateToDefoultPage()
        {
            _driver.Url = "https://demoqa.com/checkbox";
        }
        public void ClosePopUp()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(d => _popup.Displayed);
            _popup.Click();
        }
   
      public void ClickOnCommands()
        {
            foreach (IWebElement checkBox in _checkBoxes)
            {
                _checkBoxes[3].Click();
            }
        }

                
            
      
    }
}
