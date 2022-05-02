using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSAutoMokymai.Test
{
    class HomeWork3Test : BaseTest
    {
        [Test]
        public static void TestExpandAllButton()
        {
            _homeWork3Page.NavigateToDefaultPage();
            _homeWork3Page.ClosePopUp();
            _homeWork3Page.ClickExpandAllButton();
        }
    }
}
