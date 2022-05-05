﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSAutoMokymai.Test
{
    class SebCalcTest : BaseTest
    {
        [Test]
        public static void TestLoanCalculator()
        {
            _sebCalcPage.NavigateToDefaultPage()
                .ClosePopup()
                .SwitchToFrame()
                .InsertIncome("1000)")
                .SelectFromCityDropDownByValue("Klaipeda")
                .ClickCalculateButton()
                .CheckIfICanGetLoan("79 105");

        }
    }
}
