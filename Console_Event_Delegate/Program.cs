using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Event_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulation sim = new Simulation();
            var myObj_1 = new MyObject(sim);
            var myObj_2 = new MySecondObject(sim);

            sim.Run();

            Console.ReadLine();
        }
    }
}
