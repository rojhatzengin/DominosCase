using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominosCase.Constants
{
    class CampaignConstants
    {
        public static By FIRST_PRODUCT = By.Id("DPE_TR_COUPONDETAIL_DROPDOWN_PRODUCTLIST0");
        public static By FIRST_PRODUCT_CHOOSE = By.Id("DPE_TR_COUPONDETAIL_DROPDOWN_PRODUCTLIST0_ITEM0");
        public static By SECOND_PRODUCT = By.Id("DPE_TR_COUPONDETAIL_DROPDOWN_PRODUCTLIST1");
        public static By SECOND_PRODUCT_CHOOSE = By.Id("DPE_TR_COUPONDETAIL_DROPDOWN_PRODUCTLIST1_ITEM0");

        public static By FIRST_CAMPAIGN = By.Id("DPE_TR_CAMPAIGNS_TAB0_CARD0");
        public static By ADD_TO_BASKET_BUTTON = By.Id("DPE_TR_COUPONDETAIL_BUTTON_ADDTOBASKET");
    }
}
