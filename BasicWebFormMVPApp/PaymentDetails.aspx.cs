using BasicWebFormMVPApp.Presenter;
using BasicWebFormMVPApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BasicWebFormMVPApp
{
    public partial class PaymentDetails : System.Web.UI.Page, IPaymentDetailsView
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitPaymentDetails_OnClick(object sender, EventArgs e)
        {
            PaymentDetailsPresenter presenter = new PaymentDetailsPresenter(this);

            if (presenter.StorePaymentDetails())
            {
                Response.Redirect("~/PaymentComplete.aspx");
            }

            else
            {
                Response.Write("An Error Occured!");
            }
        }

        public string FirstName
        {
            get
            {
                return FirstNameTB.Text;
            }

            set
            {
                value = FirstNameTB.Text;
            }
        }

        public string SecondName
        {
            get
            {
                return SecondNameTB.Text;
            }

            set
            {
                SecondNameTB.Text = value;
            }
        }

        public string CardNumber
        {
            get
            {
                return CardNumberTB.Text;
            }

            set
            {
                CardNumberTB.Text = value;
            }
        }

        public string CardExpire
        {
            get
            {
                return CardExpireTB.Text;
            }

            set
            {
                CardExpireTB.Text = value;
            }
        }

        public string CardCVN
        {
            get
            {
                return CardCVNTB.Text;
            }

            set
            {
                CardCVNTB.Text = value;
            }
        }   

        

        public string CardType
        {
            get
            {
                return CardTypeDDL.Text;
            }

            set
            {
                CardTypeDDL.Text = value;
            }
        }        
    }
}