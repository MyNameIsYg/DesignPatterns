using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator;

internal class BagDecorator : ProductDecorator
{
    public BagDecorator(Product product) : base(product)
    {
    }

    public override float GetCost()
    {
        return base.GetCost() + (float)0.1;
    }
}
