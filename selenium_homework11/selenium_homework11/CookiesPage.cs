using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_homework11
{
    public class CookiesPage:WebPage
    {
        const string ACCEPT_COOKIES_XPATH = "//*[@id='onetrust-accept-btn-handler']";
        IWebElement _acceptCookies = null;
        public CookiesPage(IWebDriver driver, InformationLogger logger) : base(driver, logger)
        {
            _acceptCookies = FindElementsBy("Xpath", ACCEPT_COOKIES_XPATH)[0];
        }
        public void AcceptCookies()
        {
            _acceptCookies?.Click();
        }

    }
}
