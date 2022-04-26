using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_homework11
{
    public class MainPage:WebPage
    {
        const string WOMEN_BUTTON_XPATH = "//html/body/header/nav/ul[2]/li[2]/a/span";
        IWebElement _womenButton = null;
        public MainPage(IWebDriver driver, InformationLogger logger):base(driver,logger)
        { 
            _womenButton = FindElementsBy("Xpath", WOMEN_BUTTON_XPATH)[0];
        }
        public WclothePage NavigateWomenClose()
        {
            _womenButton?.Click();
            return new WclothePage(_driver, _logger);
        }

    }
}
