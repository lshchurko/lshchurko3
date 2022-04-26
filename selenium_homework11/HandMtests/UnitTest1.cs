using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using selenium_homework11;

namespace HandMtests
{
    [TestClass]
    public class PageNavigationTest
    {
        [TestMethod]
        public void WomenClosePageTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www2.hm.com/en_gb/index.html";

            InformationLogger logger = new InformationLogger();

            MainPage mainPage = new MainPage(driver,logger);

            WclothePage wclothePage = mainPage.NavigateWomenClose();

            CookiesPage cookiesPage = new CookiesPage(driver,logger);
            cookiesPage.AcceptCookies();

            Assert.IsTrue(wclothePage.WomenPageTag());

            driver.Close();
        }
    }
}