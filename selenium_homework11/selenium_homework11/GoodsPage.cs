using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_homework11
{
    public class GoodsPage:WebPage
    {
        const string GOODS_CSSelector = ".item-image";
        List<IWebElement> _goodslist;
        
        public GoodsPage(IWebDriver driver, InformationLogger logger) : base(driver, logger)
        {
            _goodslist = new List<IWebElement>();
            _goodslist = FindElementsBy("CSSselctor", GOODS_CSSelector).ToList();
            //_goodslist.Add(goods);
        }
        public ItemPage NavigateItemPage(int i)
        {
            _goodslist[i]?.Click();
            return new ItemPage(_driver, _logger);
        }
        
        public int GoodsCount()
        {
            int goodsCount = _goodslist.Count;
            return goodsCount;
        }
        //{
        //  int goodsCount = _goodslist.Count;
        //  for (int i = 0; i <= goodsCount - 1; i++)
        //    {
         //      NavigateItemPage(i);
         //      Ite
          //      WaitPage(10);
           //     driver.Navigate().GoToUrl("http://....");
           //     linksToClick = driver.FindElement(By.Id("DivId")).FindElements(By.TagName("a")).ToList();

           // }
     //   }
    }
}
