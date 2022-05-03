using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCSAutoMokymai.BaigiamasisDarbas.Page;

namespace VCSAutoMokymai.BaigiamasisDarbas.Test
{
    class ERutaSearchTest : BaseTest
    {
        [Test]

        public static void TestSearchField()
        {
            string searchText = "zara";
            string expectedResult = "zara";

            _eRutaSearchPage.NavigateToDefaultPage();
            _eRutaSearchPage.InsertTextToSerchField(searchText);
            _eRutaSearchPage.ClickSearchSubmitButton();
            _eRutaSearchPage.VerifySearchResult(expectedResult);
        }
    }
}
