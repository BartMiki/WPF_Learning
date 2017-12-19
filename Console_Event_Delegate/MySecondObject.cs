using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Event_Delegate
{
    class MySecondObject
    {

        public MySecondObject(Simulation sim)
        {
            sim.ListOfSubsribers += Print;
        }

        public void Print(string msg)
        {
            Console.WriteLine(msg + " Second Object");
        }
    }
}
