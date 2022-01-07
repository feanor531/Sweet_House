using System;
using static System.Console;
using LoggerLib;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Sweet_House
{
    class Program
    {
        
        static void Main(string[] args)
        {
            SetWindowSize(180, 40);
            Logger.LogPath = "log.txt";
            Logger.MaskPath = "log.ini";
            Logger.ReadMask();
            House house = new House();
            Team team = new Team();
            team.team.Add(new Worker("Рафшан"));
            team.team.Add(new Worker("Джамшут"));
            team.team.Add(new Worker("Лёлик"));
            team.team.Add(new Worker("Болик"));
            team.team.Add(new TeamLeader("Петрович"));
            SetCursorPosition(40, 5); WriteLine("=== SWEET HOME ===");
            SetCursorPosition(110, 10); WriteLine("=== Рапорт ===");

            team.Build(house);
            SetCursorPosition(0, 30);
        }
    }
}
