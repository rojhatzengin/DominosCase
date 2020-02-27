using DominosCase.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using DominosCase.Constants;

namespace DominosCase.Page
{
    class PaymentPage : BasePage
    {
        public PaymentPage(IWebDriver _driver) : base(_driver)
        {
        }

        public void SelectCash()
        {
            ClickWithWait(PaymentConstants.CASH);
        }
    }
}
