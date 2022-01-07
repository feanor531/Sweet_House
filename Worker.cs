using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggerLib;

namespace Sweet_House
{
    class Worker : IWorker
    {
        public string Name { get; set; }
        public string Profesion { get; set; } = "рабочий";
        public string WorkName { get; set; }
        public Worker(string name)
        {
            Name = name;
        }
        public void DoSomething(House house)
        {
            WorkName = "Помощь/Уборка территории"; //заглушка на случай если не хватило работы
            var min = house.Part.ElementAt(0);
            int i = 0;
            foreach(IPart item in house.Part)
            {
                if(item.Prioritet == house.NowPrioritet && item.IsBuilt == false) //ищу приоритетную задачу
                {
                    if (item.BuiltingTime < min.BuiltingTime) min = house.Part.ElementAt(i); // ищу минимально выполненое задание
                }
                i++;
            }
            
            if (min.BuiltingTime < min.InstallationTime) 
            { 
                min.BuiltingTime++; 
                WorkName = min.Name;
                
                min.Show();
            }//строю
            if (min.InstallationTime <= min.BuiltingTime) { min.IsBuilt = true; }// Проверка - построил ли?
            Logger.WriteLog(Name, "Занятие: " + WorkName);
        }

    }
}
