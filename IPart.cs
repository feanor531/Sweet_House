using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweet_House
{
    interface IPart
    {
        bool IsBuilt { get; set; }
        int Prioritet { get; set; }
        int InstallationTime { get; set; } //время в человеко днях необходимого для монтажа 
        int BuiltingTime { get; set; } //затраченное время
        string Name { get; }
        void Show();    
    }
}
