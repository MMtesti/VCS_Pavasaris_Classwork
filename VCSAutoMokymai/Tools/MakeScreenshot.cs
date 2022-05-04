using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VCSAutoMokymai.Tools
{
    class MakeScreenshot
    {
        public static void takeScreenshot(IWebDriver webDriver)
        {
            Console.WriteLine(Assembly.GetExecutingAssembly().Location);

            string a = Assembly.GetExecutingAssembly().Location.ToString();
        }
        
    }
}
