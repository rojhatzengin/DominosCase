using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominosCase.Constants
{
    class PaymentConstants
    {
        public static By CASH = By.Id("DPE_TR_PAYMENTTYPE_BUTTON_TYPEGUEST1");
        public static By CONTINUE_PAYMENT = By.Id("DPE_TR_PAYMENTOPTIONS_BUTTON_CONTINUEGUEST-D");
    }
}
