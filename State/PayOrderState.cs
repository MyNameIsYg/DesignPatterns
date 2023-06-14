using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    internal class PayOrderState : IMachineState
    {
        public string ProcessOrder(Form1 machine)
        {
            return "Product already selected.";
        }

        public string PayOrder(Form1 machine)
        {
            machine.SetState(new CompleteOrderState());
            return "Choose a payment method.";
        }

        public string CompleteOrder(Form1 machine)
        {
            return "Cannot complete. Choose a payment method.";
        }
    }
}
