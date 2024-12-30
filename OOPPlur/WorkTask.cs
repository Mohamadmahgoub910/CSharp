using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPlur
{
    internal struct WorkTask
    {
        public string description;
        public int hours;

        public void performWorkTask()
        {
            Console.WriteLine($"Task {description} of {hours} hour(s) has been performed");
        }
    }
}
