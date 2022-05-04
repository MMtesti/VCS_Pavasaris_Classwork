using OpenQA.Selenium;

namespace VCSAutoMokymai.BaigiamasisDarbas.Page
{
    class ERutaShoppingCartPage : BasePage
    {
        private const string PageAddress = "https://www.e-ruta.lt/prekiu-krepselis";

        private IWebElement _shoppingCartText => Driver.FindElement(By.Id("cart-title"));// pirkini7 krepselis
        private IWebElement _cartValue => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div[1]/div/div[5]/div/div[1]/text()"));// krepselis tuscias

        public ERutaShoppingCartPage(IWebDriver webDriver) : base(webDriver) { }

        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;
        }

    }
}
