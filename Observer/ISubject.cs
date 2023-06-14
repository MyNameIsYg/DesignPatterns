using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public interface ISubject
    {
        void RegisterSuppiler(IObserver observer);
        void UnregisterSuppiler(IObserver observer);
        void NotifySuppiler(Product product);
    }
}
