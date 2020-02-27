using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominosCase.Base
{
    class BasePage
    {
        IWebDriver driver;
        public BasePage(IWebDriver _driver)
        {
            this.driver = _driver;
        }

        // Tüm sayfalara Click(Tiklama) eklemek icin
        public void Click(By element)
        {
            FindElement(element).Click();
        }

        // Tüm sayfalara SendKeys(Yazi Girme) eklemek icin
        public void SendKeys(By element, string text)
        {
            FindElement(element).SendKeys(text);
        }

        public void ClickWithWait(By element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            IWebElement el = wait.Until(ExpectedConditions.ElementToBeClickable(element));
            el.Click();
        }

        // Tum sayfalarda FindElement(Elamani Bulma) fonksiyonunu ekler
        public IWebElement FindElement(By element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            return wait.Until(ExpectedConditions.ElementIsVisible(element));
        }

        // Tum sayfalara HoverElement(Fareyi elemanin ustune goturme) fonksiyonunu ekler
        public void HoverElement(By by)
        {
            IWebElement element = FindElement(by);

            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }

        public void SelectDropdown(By by, string selectValue)
        {
            IWebElement dropdownElement = FindElement(by);
            dropdownElement.Click();

            IWebElement menuItem = dropdownElement.FindElement(By.XPath("//div[contains(@class, 'menuItem') and contains(., '"+ selectValue +"')]"));
            menuItem.Click();
        }
    }
}
