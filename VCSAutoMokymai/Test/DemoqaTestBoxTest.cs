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
    class DemoqaTestBoxTest : BaseTest
    {
    

        [Test]
        public static void TestFullNameInputField()
        {
            string fullName = "Milda";

            _demoqaTestBoxPage.NavigateToDefaultPage();
            _demoqaTestBoxPage.InsertTextToFullNameField(fullName);
            _demoqaTestBoxPage.ClickSubmitButton();

            _demoqaTestBoxPage.VerifyFullNameResult(fullName);

        }
    }
}
