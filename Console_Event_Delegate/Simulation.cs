using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Event_Delegate
{
    class Simulation
    {
        //delegat to sygnatura wszystkich funkcji o zracanym typie i parametrach
        public delegate void WhenCounterIsEven(string str);

            /* Opcjonalnie można zrobić accessory
            private WhenCounterIsEven _listOfSubsribers;
            */

        //event oznacza, że ListOfSubsribers możemy wywołać tylko z tej klasy
        //z zewnątrz można tylko zapisywać i wypisywać się ze subskrybcji
        public event WhenCounterIsEven ListOfSubsribers;
        
            /* Tutaj są accessory: add i remove. Używa się ich specjalnych przypadkach
            {
                add
                {
                    //dodaje do listy subsktybentów
                    _listOfSubsribers += value;
                }
                remove
                {
                    //usuwa z listy subskrybentów
                    _listOfSubsribers -= value;
                }
            }
            */

        public int Counter { get; set; }

        public Simulation()
        {
            Counter = 0;
        }

        public void Run(int range = 10)
        {
            while (Counter++ < range)
            {
                if ((Counter % 2) == 0)
                {
                    Console.WriteLine(Counter);
                    //jeżeli ListOfSubscribers != null to wywołaj .Invoke(...)
                    ListOfSubsribers?.Invoke("Current time: " + Counter.ToString());
                }
                System.Threading.Thread.Sleep(100);
            }
            Counter = 0;
        }
    }
}
