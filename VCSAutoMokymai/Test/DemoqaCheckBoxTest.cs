using NUnit.Framework;

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
