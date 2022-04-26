using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using selenium_homework11;
using System.Threading;

namespace HandMtests
{
    [TestClass]
    public class SearchTest
    {
        [TestMethod]
        public void SearchPageTest()
        {
            string value = "anna";
            //string value2 = "Anna, Elsa";
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www2.hm.com/en_gb/index.html";

            InformationLogger logger = new InformationLogger();

            MainPage mainPage = new MainPage(driver,logger);
            WclothePage wclothePage = mainPage.NavigateWomenClose();
            Thread.Sleep(2000);
            CookiesPage cookiesPage = new CookiesPage(driver,logger);
            cookiesPage.AcceptCookies();
            Thread.Sleep(2000);
            // wclothePage.SearchClick();
            wclothePage.SearchValue(value);
            GoodsPage goodsPage =  wclothePage.LoupeIconClick();

            //for (int i = 0; i + 1 <= goodsPage.GoodsCount(); i++)
            for(int i = 0; i <= 3; i++)
            {
                Thread.Sleep(2000);
                ItemPage itemPage = goodsPage.NavigateItemPage(i);
                Thread.Sleep(2000);
                DetailsPage detailsPage = itemPage.ItemDetails();
                Thread.Sleep(2000);
                Assert.AreEqual(detailsPage.DescriptionValue(value),1);
                //Assert.AreEqual(detailsPage.DescriptionValue2(value2),1);
                Thread.Sleep(2000);
                detailsPage.CloseDetails();
                Thread.Sleep(2000);
                itemPage.NavigateBack();
                goodsPage = new GoodsPage(driver,logger);

            }
            driver.Close();
        }
    }
}