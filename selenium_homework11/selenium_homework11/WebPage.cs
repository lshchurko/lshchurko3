using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_homework11
{
    public abstract class WebPage
    {
        protected IWebDriver _driver;
        protected InformationLogger _logger;

        public WebPage(IWebDriver driver, InformationLogger logger)
        {
            _driver = driver;
            _logger = logger;
        }
        public List<IWebElement> FindElementsBy( string bytype, string locator)
        {
            List<IWebElement> element = null;
            int atemptQuant = 0;
            while (atemptQuant <3)
            {
                try
                {
                    if (bytype == "Xpath")
                    {
                        element = _driver.FindElements(By.XPath(locator)).ToList();
                    }
                    else if (bytype == "CSSselctor")
                    {
                        element = _driver.FindElements(By.CssSelector(locator)).ToList();
                    }
                }
                catch (Exception ex)
                {
                    Thread.Sleep(1000);
                    _logger.Log("Element is not here. Re-trying ...");
                }
                if (element != null)
                {
                    break;
                }
                atemptQuant++;
            }
            return element;
        }

        public void NavigateBack()
        {
            _driver.Navigate().Back();
        }
    }
}
