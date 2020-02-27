using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominosCase.Constants
{
    class MainConstants
    {
        public static By DELIVERY_BUTTON = By.Id("DPE_TR_SERVICETYPEMODAL_BUTTON_DELIVERY");
        public static By CITY_DROPDOWN = By.Id("DPE_TR_STOREFILTERFORMDELIVERY_DROPDOWN_CITY");
        public static By COUNTRY_DROPDOWN = By.Id("DPE_TR_STOREFILTERFORMDELIVERY_DROPDOWN_COUNTY");
        public static By DISTRICT_DROPDOWN = By.Id("DPE_TR_STOREFILTERFORMDELIVERY_DROPDOWN_DISTRICT");
        public static By ADDRESS_SELECT_BUTTON = By.Id("DPE_TR_STOREFILTERFORMDELIVERY_BUTTON_ADDRESSSELECT");
        public static By CAMPAIGNS_BUTTON = By.Id("DPE_TR_HOME_BUTTON_CAMPAIGNS");

        public static By CAMPAIGNS_MENU = By.CssSelector("a.styled__HeaderMenuItem-sc-126ws66-35[href='/kampanyalar']");

        public static By CONFIRM_COOKIE = By.CssSelector("div.styled__ConfirmCookie-vl63gb-2 > button");
        public static By CART_HOVER = By.CssSelector("button.styled__CartButton-sc-126ws66-17");
        public static By CART_BUTTON = By.CssSelector("a.styled__BasketButton-sc-126ws66-37");
    }
}
