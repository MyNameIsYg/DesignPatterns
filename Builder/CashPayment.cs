using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder;

internal class CashPayment : Payment
{
    public CashPayment() : base(PaymentType.Cash)
    {

    }

    public override void ProcessPayment()
    {
        MessageBox.Show("The payment was successfully completed");
    }
}
