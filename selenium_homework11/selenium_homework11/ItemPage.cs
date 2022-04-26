using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_homework11
{
    public class ItemPage: WebPage
    {
        const string ITEM_DETAIL_XPATH = "//*[@id='main-content']/div[1]/div[2]/div[2]/menu/ul/li[1]/button";
        IWebElement _detailButton = null;
        public ItemPage(IWebDriver driver, InformationLogger logger) : base(driver, logger)
        {
            _detailButton = FindElementsBy("Xpath", ITEM_DETAIL_XPATH)[0];
        }
        public DetailsPage ItemDetails()
        {
            _detailButton?.Click();
            return new DetailsPage(_driver,_logger);
        }
    }
}
