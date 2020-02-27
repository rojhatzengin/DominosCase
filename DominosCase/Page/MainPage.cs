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
    class MainPage : BasePage
    {
        public MainPage(IWebDriver _driver) : base(_driver)
        {
        }

        public void SelectServiceType()
        {
            Click(MainConstants.DELIVERY_BUTTON);
            SelectDropdown(MainConstants.CITY_DROPDOWN, "İstanbul");
            SelectDropdown(MainConstants.COUNTRY_DROPDOWN, "Adalar");
            SelectDropdown(MainConstants.DISTRICT_DROPDOWN, "Burgazada Mh.");
            Click(MainConstants.ADDRESS_SELECT_BUTTON);
        }

        public void ConfirmCookie()
        {
            Click(MainConstants.CONFIRM_COOKIE);
        }

        public void NavigateToCampaings()
        {
            ClickWithWait(MainConstants.CAMPAIGNS_BUTTON);
        }

        public void NavigateToBasket()
        {
            HoverElement(MainConstants.CART_HOVER);
            ClickWithWait(MainConstants.CART_HOVER);
            ClickWithWait(MainConstants.CART_BUTTON);
        }
    }
}
