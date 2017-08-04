using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicWebFormMVPApp.Model
{
    public class PaymentDetailsModel : IPaymentDetailsModel
    {
        public bool StorePaymentDetails(List<string>PaymentDetailsList)
        {
            try
            {
                using (var db = new PaymentInfoDataContext())
                {
                    PaymentDetails paymentDetail = new PaymentDetails();
                    paymentDetail.FirstName = PaymentDetailsList[0];
                    paymentDetail.SecondName = PaymentDetailsList[1];
                    paymentDetail.CardNumber = PaymentDetailsList[2];
                    paymentDetail.CardExpire = PaymentDetailsList[3];
                    paymentDetail.CardType = PaymentDetailsList[4];
                    paymentDetail.CardCVN = PaymentDetailsList[5];

                    db.PaymentDetails.InsertOnSubmit(paymentDetail);
                    db.SubmitChanges();
                }

                return true;
            }
            catch 
            {
                return false;
            }
        }
    }
}