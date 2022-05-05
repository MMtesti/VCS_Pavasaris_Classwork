using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSAutoMokymai.Page
{
    class SenukaiPage : BasePage
    {
        private const string PageAddress = "https://www.senukai.lt/";
        public SenukaiPage(IWebDriver webDriver) : base(webDriver) { }

        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;
        }

        public void AcceptCookies()
        {
            Cookie myCookie = new Cookie("CookieConsent",
                "{stamp:%270lIcpTegmrXke0YX5PV8GQveHMzQq0C2e1NI4/Bw/d5voEO6b2VlnQ==%27%2Cnecessary:true%2Cpreferences:true%2Cstatistics:false%2Cmarketing:false%2Cver:1%2Cutc:1647157895720%2Cregion:%27lt%27}",
                "www.senukai.lt",
                "/",
                DateTime.Now.AddDays(5));
            Driver.Manage().Cookies.AddCookie(myCookie);
            Driver.Navigate().Refresh();

        }
    }
}
