using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWebFormMVPApp.View
{
    public interface IPaymentDetailsView
    {
        string FirstName { get; set; }
        string SecondName { get; set; }
        string CardNumber { get; set; }
        string CardExpire { get; set; }
        string CardType { get; set; }
        string CardCVN { get; set; }
    }
}
