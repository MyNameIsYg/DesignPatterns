using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator;

internal class ProductDecorator : Product
{
    Product product;
    public ProductDecorator(Product product)
    {
        this.product = product;
    }

    public override float GetCost()
    {
        return product.GetCost();
    }
}

