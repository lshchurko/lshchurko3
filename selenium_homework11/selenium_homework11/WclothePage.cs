using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_homework11
{
    public class WclothePage:WebPage
    {
        const string SEARCH_BUTTON_CSSelector = ".xs-21294870578-search-button";
        const string SEARCH_INPUT_XPATH = "//*[@id='main-search']";
        //const string WOMEN_TAG_XPATH = "//*[@id='main-content']/nav/ul/li[2]/a/span [contains(text(),'Women')]";
        const string WOMEN_TAG_XPATH = "//*[@data-testid='breadcrumb'] [contains(text(),'Women')]";
        const string LOUPE_ICON_XPATH = "//*[@id='search-field']/form/button";
        Dictionary<string, IWebElement> _dictionary;
        public WclothePage(IWebDriver driver, InformationLogger logger):base(driver, logger)
        {
            _dictionary = new Dictionary<string, IWebElement>();
            //var searchButton = FindElementsBy("CSSselctor", SEARCH_BUTTON_CSSelector)[0];
            //_dictionary.Add("Search button",searchButton);
            var searchInput = FindElementsBy("Xpath", SEARCH_INPUT_XPATH)[0];
            _dictionary.Add("Search input", searchInput);
            var womenTag = FindElementsBy("Xpath", WOMEN_TAG_XPATH)[0];
            _dictionary.Add("Women page tag", womenTag);
            var loupeIcon = FindElementsBy("Xpath", LOUPE_ICON_XPATH)[0];
            _dictionary.Add("Loupe icon", loupeIcon);

        }
        //public void SearchClick()
        //{
        //    _dictionary["Search button"].Click();
        //}
        public void SearchValue(string value)
        {            
            _dictionary["Search input"]?.SendKeys(value);
            _logger.Log("Searche done");
        }
        public GoodsPage LoupeIconClick()
        {
            _dictionary["Loupe icon"]?.Click();
            return new GoodsPage(_driver, _logger);
        }
         public bool WomenPageTag()
         {
            return _dictionary["Women page tag"] != null;
         }
    }
}
