using BasicWebFormMVPApp.Model;
using BasicWebFormMVPApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicWebFormMVPApp.Presenter
{
    public class PaymentDetailsPresenter
    {
        IPaymentDetailsView view;

        public PaymentDetailsPresenter(IPaymentDetailsView view)
        {
            this.view = view;
        }

        public bool StorePaymentDetails()
        {
            PaymentDetailsModel model = new PaymentDetailsModel();

            List<string> myPaymentDetailsList = new List<string>();
            myPaymentDetailsList.Insert(0, view.FirstName);
            myPaymentDetailsList.Insert(1, view.SecondName);
            myPaymentDetailsList.Insert(2, view.CardNumber);
            myPaymentDetailsList.Insert(3, view.CardExpire);
            myPaymentDetailsList.Insert(4, view.CardType);
            myPaymentDetailsList.Insert(5, view.CardCVN);

            return model.StorePaymentDetails(myPaymentDetailsList);
        }
    }
}