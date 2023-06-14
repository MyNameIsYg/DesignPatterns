using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory;

internal class LoggingToText : Logging
{
    string txt = "";

    public override void InsertFile(string text)
    {
        this.txt = DateTime.Now + "\n" + text;
        TypeFile("txt");
    }

    public override void WriteToFile(string name)
    {
        using (StreamWriter file = new(name, true))
        {
            file.WriteLine(txt);
            file.Close();
            file.Dispose();
        }
    }
}
