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
    class DemoqaCheckBoxTest : BaseTest
    {


        [Test]
        public static void TestExpandAllButton()
        {
            _demoqaCheckBoxPage.NavigateToDefaultPage();
            _demoqaCheckBoxPage.ClosePopUp();
            _demoqaCheckBoxPage.ClickExpandAllButton();
        }

    }
}
