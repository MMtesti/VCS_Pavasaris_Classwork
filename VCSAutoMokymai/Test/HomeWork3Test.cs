using NUnit.Framework;

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
