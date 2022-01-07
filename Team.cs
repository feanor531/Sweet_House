using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggerLib;

namespace Sweet_House
{
    class Team
    {
        public List<IWorker> team { get; set; }
        public Team()
        {
            team = new List<IWorker>();
        }
        public void Build(House house)
        {
            while (house.Part.Count() > 0)
            {
                foreach (IWorker item in team)
                {
                    item.DoSomething(house);
                }
                
            }
        }
    }
}
