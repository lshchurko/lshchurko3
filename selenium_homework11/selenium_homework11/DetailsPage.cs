using OpenQA.Selenium;
using System.Linq;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_homework11
{
    public class DetailsPage:WebPage
    {
        const string DESCRIPTION_CSSelector=".details-list-item";
        const string CLOSE_DETAILS_XPATH = "//*[@id='side-drawer-3']/header/button";
        List <IWebElement> _descriptionlist;
        IWebElement _closeDetails = null;

        public DetailsPage(IWebDriver driver, InformationLogger logger) : base(driver, logger)
        {
            _descriptionlist = new List<IWebElement>();
            _descriptionlist = FindElementsBy("CSSselctor", DESCRIPTION_CSSelector);
            _closeDetails = FindElementsBy("Xpath", CLOSE_DETAILS_XPATH)[0];
        }

        public int DescriptionValue(string value)
        {
            //var descriptin = _descriptionlist.Where(x => x.Text.ToLower() == value.ToLower()).ToList();
            //var descriptin = _descriptionlist.Where(x => x.Text.ToLower() == value.ToLower()).ToList();
            var descriptin = _descriptionlist.Where(x => x.Text.ToLower().Contains(value.ToLower()));
            return descriptin.Count();
        }

        public int DescriptionValue2(string value2)
        {
            var des = _descriptionlist.Where(x => x.Text.ToLower()!= null).ToList();
            return des.Count;
        }
        public ItemPage ReturnItemPage()
        {
            _closeDetails?.Click();
            return new ItemPage(_driver, _logger);
        }
        public void CloseDetails()
        {
            _closeDetails?.Click();
        }
    }
}
