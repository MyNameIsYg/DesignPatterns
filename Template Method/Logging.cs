using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public abstract class Logging
    {
        const string PATH = @"..\..\..\..\..\Files";
        public abstract void WriteToFile(string name);
        public void TypeFile(string type)
        {
            if (!Directory.Exists(PATH))
            {
                Directory.CreateDirectory(PATH);
            }
            string AllPath = $@"{PATH}\{DateTime.Now:dd_MM_yy}.{type}";
            if (!File.Exists(AllPath))
            {
                File.Create(AllPath);
            }
            WriteToFile(AllPath);

        }
        public abstract void InsertFile(string text);
    }
}
