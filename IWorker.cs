using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweet_House
{
    interface IWorker
    {
        string Name { get; set; }
        string Profesion { get; set; }
        void DoSomething(House house);
    }
}
