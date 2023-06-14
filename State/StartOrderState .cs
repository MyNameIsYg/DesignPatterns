using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State;

internal class StartOrderState : IMachineState
{
    public string ProcessOrder(Form1 machine)
    {
        machine.SetState(new PayOrderState());
        return "Select product.";
    }

    public string PayOrder(Form1 machine)
    {
        return "Cannot pay. No product selected.";
    }

    public string CompleteOrder(Form1 machine)
    {
        return "Cannot complete. No product selected.";
    }
}
