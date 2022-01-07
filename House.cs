using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweet_House
{

    class House
    {
        public List<IPart> Part { get; set; }
        public int NowPrioritet { get; set; } = 1;
        
        public House()
        {
            Part = new List<IPart>();
            Part.Add(new Basement(3, 1, 3, 23));
            Part.Add(new Wall(10, 2, 5, 24, "Стена 1"));
            Part.Add(new Wall(10, 2, 27, 24, "Стена 2"));
            Part.Add(new Wall(10, 2, 49, 24, "Стена 3"));
            Part.Add(new Wall(10, 2, 71, 24, "Стена 4"));
            Part.Add(new Roof(5, 3, 3, 13));
            Part.Add(new Window(1, 4, 8, 19, "Окно 1"));
            Part.Add(new Window(1, 4, 25, 19, "Окно 2"));
            Part.Add(new Window(1, 4, 65, 19, "Окно 3"));
            Part.Add(new Window(1, 4, 82, 19, "Окно 4"));
            Part.Add(new Door(1, 4, 44, 22));
        }
    }
}
