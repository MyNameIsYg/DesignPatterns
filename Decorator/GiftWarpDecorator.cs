using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesignPatterns.Decorator;

internal class GiftWarpDecorator : ProductDecorator
{
    public GiftWarpDecorator(Product product) : base(product)
    {
    }
    public override float GetCost()
    {
        return base.GetCost() + (float)3.5;
    }
}
;