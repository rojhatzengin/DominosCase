using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominosCase.Constants
{
    class BasketConstants
    {
        public static By ORDER_BUTTON = By.Id("DPE_TR_BASKET_BUTTON_ORDER");
        public static By APARTMENT_NUMBER = By.Id("DPE_TR_ADDRESSADDMODAL_DROPDOWN_APARTMENTNUMBER");
        public static By DOOR_NUMBER = By.Id("DPE_TR_ADDRESSADDMODAL_INPUT_DOORNUMBER");
        public static By PHONE_NUMBER = By.Id("DPE_TR_ADDRESSADDMODAL_INPUT_PHONE");
        public static By ADDRESS_INSTRUCTION = By.Id("DPE_TR_ADDRESSADDMODAL_INPUT_INSTRUCTIONS");
        public static By STREET_DROPDOWN = By.Id("DPE_TR_ADDRESSADDMODAL_DROPDOWN_STREETS");
        public static By FIRST_ADDRESS = By.Id("DPE_TR_ADDRESSLISTDELIVERY_BUTTON_ADDRESSITEM0");
        public static By SELECT_ADDRESS = By.Id("DPE_TR_ADDRESSLISTDELIVERY_BUTTON_SELECTADDRESS");
        public static By SAVE_ADDRESS = By.Id("DPE_TR_ADDRESSADDMODAL_BUTTON_SAVE");
    }
}
