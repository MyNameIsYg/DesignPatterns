using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State;

internal class CompleteOrderState : IMachineState
{
    public string ProcessOrder(Form1 machine)
    {
        return "Order already processed.";
    }

    public string PayOrder(Form1 machine)
    {
        return "Order already paid.";
    }

    public string CompleteOrder(Form1 machine)
    {
        machine.SetState(new StartOrderState());
        return "Order completed successfully.";
    }
}
