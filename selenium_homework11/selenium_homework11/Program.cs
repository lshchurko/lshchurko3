using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace selenium_homework11
{
    public class Program
    {
        static void Main(string[] arg)
        {
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://www2.hm.com/en_gb/index.html";
            Thread.Sleep(2000);
            IWebElement womanCklic = driver.FindElement(By.XPath("//html/body/header/nav/ul[2]/li[2]/a/span"));
            womanCklic.Click();
            Thread.Sleep(2000);

            //var textPage = driver.FindElement(By.XPath("//div[contains(text(),'Women's Clothing')]"));


            //IWebElement searchClick = driver.FindElement(By.CssSelector(".xs-21294870578-search-button"));
            //IWebElement searchClick = driver.FindElement(By.XPath("//*[@id='main-search']"));
            //searchClick.Click();
            IWebElement sortingClick = driver.FindElement(By.XPath("//*[@id='main-search']"));
            sortingClick.SendKeys("anna");
            IWebElement buyClick = driver.FindElement(By.XPath("//*[@id='search-field']/form/button"));
            buyClick.Click();
            IWebElement cookiesClick = driver.FindElement(By.XPath("//*[@id='onetrust-accept-btn-handler']"));
            cookiesClick.Click();
            IWebElement sortClick = driver.FindElement(By.XPath("//*[@id='page-content']/div[1]/div[1]/div[1]/form/fieldset[2]/button"));
            sortClick.Click();
            IWebElement priseClick = driver.FindElement(By.XPath("//*[@id='dropdown-sort']/ul/li[3]"));
            priseClick.Click();
            Thread.Sleep(2000);
            IWebElement closeSorting =driver.FindElement(By.XPath("//*[@id='page-content']/div[1]/div[1]/div[1]/form/fieldset[2]/button"));
            closeSorting.Click();
            Thread.Sleep(2000);
            IWebElement firstGoods = driver.FindElement(By.CssSelector(".item-image"));
            firstGoods.Click();
            Thread.Sleep(2000);
            IWebElement addCourt = driver.FindElement(By.XPath("//*[@id='main-content']/div[1]/div[2]/div[1]/div[1]/div/div[4]/div[1]/button"));
            driver.ExecuteScript("arguments[0].scrollIntoView(true);", addCourt);
            Thread.Sleep(2000);
            addCourt.Click();
            driver.Close();
        }
    }
}