using DesignPatterns.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns;

public class Product
{
    Logging log = new LoggingToText();
    public string NameProduct { get; set; }
    public float Price { get; set; }


    public virtual float GetCost()
    {
        return Price;
    }

    public void AddProductToFile()
    {
        log.InsertFile($"add a {NameProduct}");
    }
    public override bool Equals(object obj)
    {
        Product otherProduct = (Product)obj;
        return NameProduct == otherProduct.NameProduct && Price == otherProduct.Price;
    }

    public override int GetHashCode()
    {
        return NameProduct.GetHashCode() ^ Price.GetHashCode();
    }

}
