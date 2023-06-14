using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder;

internal abstract class Payment
{
    public PaymentType Type { get; set; }

    public Payment(PaymentType type)
    {
        this.Type = type;
    }
    public abstract void ProcessPayment();

}

public enum PaymentType
{
    Cash,
    CarditCard
}