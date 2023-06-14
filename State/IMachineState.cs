using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State;

public interface IMachineState
{
    string ProcessOrder(Form1 machine);
    string PayOrder(Form1 machine);
    string CompleteOrder(Form1 machine);
}
