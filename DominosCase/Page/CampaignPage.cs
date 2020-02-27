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
    class CampaignPage : BasePage
    {
        public CampaignPage(IWebDriver _driver) : base(_driver)
        {
        }

        public void SelectRandomCampaign()
        {
            Click(CampaignConstants.FIRST_CAMPAIGN);
        }

        public void SelectProducts()
        {
            HoverElement(CampaignConstants.FIRST_PRODUCT);
            Click(CampaignConstants.FIRST_PRODUCT);
            HoverElement(CampaignConstants.FIRST_PRODUCT_CHOOSE);
            Click(CampaignConstants.FIRST_PRODUCT_CHOOSE);

            HoverElement(CampaignConstants.SECOND_PRODUCT);
            Click(CampaignConstants.SECOND_PRODUCT);
            HoverElement(CampaignConstants.SECOND_PRODUCT_CHOOSE);
            Click(CampaignConstants.SECOND_PRODUCT_CHOOSE);

            HoverElement(CampaignConstants.ADD_TO_BASKET_BUTTON);
            Click(CampaignConstants.ADD_TO_BASKET_BUTTON);
        }
    }
}
