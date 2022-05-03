using NUnit.Framework;

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
