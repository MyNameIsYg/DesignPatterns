using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer;

public class Supplier : IObserver
{
    public void Update(Product product)
    {
        //sms
        MessageBox.Show($"this product: {product.NameProduct} almost over");
    }
}


