using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSAutoMokymai.Test
{
    class AlertTest : BaseTest
    {
        [Test]
        public static void TestFirstAlert()
        {
            _alertPage.NavigateToDefaultPage();
            _alertPage.ClickFirstAlertButton();
            _alertPage.AcceptFirstAlert();
        }
        [Test]
        public static void TestSecondAlert()
        {
            // toks uzrasymo budas glaima Page objektuose yrasius vietoje void AlertPage ir return this
            _alertPage.NavigateToDefaultPage()
                .ClickSecondAlertButton()
                .CancelSecondAlertButton()
                .CancelSecondAlertButton()
                .VerifySecondAlertText("Cancel");
        }
    }
}
