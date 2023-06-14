using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder;

internal class CarditCardPayment : Payment
{
    public CarditCardPayment() : base(PaymentType.CarditCard)
    {

    }

    public override void ProcessPayment()
    {
        MessageBox.Show("The payment was successfully completed");
    }
}
