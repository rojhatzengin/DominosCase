using DominosCase.Constants;
using DominosCase.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// dominos.com.tr >
// Servis tipi seçimi > 
// (Bölge Seçimi) > 
// Anasayfa > 
// Tüm Kampanyalar > 
// Random Kampanya Seçimi > 
// Sepete Ekle > 
// Sepete Git > 
// Sepeti Onayla > 
// Adresi Tamamla > 
// (Şube Seç) > 
// Ödeme Tipi Seç > 
// Devam Et (Burada testi sonlandır.)

namespace DominosCase.Test
{
    [TestFixture]
    class MainTest
    {
        IWebDriver driver;
        MainPage mainPage;
        CampaignPage campaignPage;
        BasketPage basketPage;
        PaymentPage paymentPage;

        [SetUp]
        public void SetUp()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            options.AddArguments("test-type");
            driver = new ChromeDriver(options);
            mainPage = new MainPage(driver);
            campaignPage = new CampaignPage(driver);
            basketPage = new BasketPage(driver);
            paymentPage = new PaymentPage(driver);
            driver.Navigate().GoToUrl("http://www.dominos.com.tr");
        }

        [Test]
        public void TestDominosCase()
        {
            mainPage.SelectServiceType();
            mainPage.ConfirmCookie();
            mainPage.NavigateToCampaings();

            campaignPage.SelectRandomCampaign();
            campaignPage.SelectProducts();

            mainPage.NavigateToBasket();

            basketPage.ConfirmBasket();
            basketPage.FillAddress();
            basketPage.SelectFirstAddress();

            paymentPage.SelectCash();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
