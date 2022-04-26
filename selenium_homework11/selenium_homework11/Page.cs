using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_homework11
{
    public abstract class Page
    {
        protected IWebDriver _driver;
        protected InformationLogger _logger;

        public Page(IWebDriver driver, InformationLogger logger)
        {
            _driver = driver;
            _logger = logger;
        }
        public IWebElement FindElementBy( string bytype, string locator)
        {
            IWebElement element = null;
           // List<IWebElement> element;
            int atemptQuant = 0;
            while (atemptQuant <3)
            {
                try
                {
                    if (bytype == "Xpath")
                    {
                        element = _driver.FindElement(By.XPath(locator));
                    }
                    else if (bytype == "CSSselctor")
                    {
                        element = _driver.FindElement(By.CssSelector(locator));
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
    }
}
