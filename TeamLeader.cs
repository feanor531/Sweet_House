using System;
using static System.Console;
using LoggerLib;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweet_House
{
    class TeamLeader : IWorker
    {
        public string Name { get; set; }
        public string Profesion { get; set; } = "Бугор";
        DateTime Date;
        public Dictionary<string, DateTime> Report { get; set; }
        int day = 0;
        public TeamLeader(string name)
        {
            Name = name;
            Report = new Dictionary<string, DateTime>();
            Date = DateTime.Now;
        }
        public void DoSomething(House house)
        {
            bool nextPrioritet = true;
            //Report.Clear();            
            foreach (IPart item in house.Part)
            {
                if (item.IsBuilt == true) { Report.Add(item.Name, Date.AddDays(day)); } // добавляю в рапорт Последние законченные задачи
            }
            day++;
            List<IPart> P = house.Part.Where(x => x.IsBuilt == false).ToList(); // удаляю из списка построенный элемент
            house.Part.Clear();
            house.Part = P;
            if (house.Part.Count == 0) // Если всевыполнили - приветствие
            {
                Report.Add("всего дома", Date.AddDays(day));
                SetCursorPosition(40, 25);
                Write("У-у-у-у ТИГРЫ!!!!");
                SetCursorPosition(35, 26);
                Write($"Постороили дом за {day} дней!!!");
            }
            foreach (IPart item in house.Part)
            {
                if (house.NowPrioritet == item.Prioritet) nextPrioritet = false; // если не закончены приоритеные задания то продолжаем...
            }
            if (nextPrioritet == true) house.NowPrioritet++;
            int i = 0;
            SetCursorPosition(110, 11); WriteLine($"    День {day}");
            foreach (var item in Report)
            {
                SetCursorPosition(100, 12 + i);
                Write($"{item.Value:M} Закончена установка {item.Key}");
                i++;
            }
            Logger.WriteLog(Name, "Заполнение отчета");
        }
    }
}
