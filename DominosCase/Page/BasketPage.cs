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
    class BasketPage : BasePage
    {
        public BasketPage(IWebDriver _driver) : base(_driver)
        {
        }

        public void ConfirmBasket()
        {
            HoverElement(BasketConstants.ORDER_BUTTON);
            Click(BasketConstants.ORDER_BUTTON);
        }

        public void FillAddress()
        {
            SelectDropdown(BasketConstants.STREET_DROPDOWN, "Azizler Sk.");
            SendKeys(BasketConstants.DOOR_NUMBER, "2/A");
            SendKeys(BasketConstants.APARTMENT_NUMBER, "12");
            SendKeys(BasketConstants.PHONE_NUMBER, Keys.Home + "5052323322");
            SendKeys(BasketConstants.ADDRESS_INSTRUCTION, "Ev");
            HoverElement(BasketConstants.SAVE_ADDRESS);
            ClickWithWait(BasketConstants.SAVE_ADDRESS);
        }

        public void SelectFirstAddress()
        {
            ClickWithWait(BasketConstants.FIRST_ADDRESS);
            HoverElement(BasketConstants.SELECT_ADDRESS);
            ClickWithWait(BasketConstants.SELECT_ADDRESS);
        }
    }
}
