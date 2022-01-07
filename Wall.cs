using System;
using static System.Console;
//using System.Collections.Generic;
using System.Threading;

namespace Sweet_House
{
    class Wall : IPart
    {
        public Wall(int installationTime, int prioritet, int posX, int posY, string name)
        {
            InstallationTime = installationTime;
            Prioritet = prioritet;
            x = posX;
            y = posY;
            Name = name;
        }

        public bool IsBuilt { get; set; } = false;
        public int InstallationTime { get; set; }
        public int BuiltingTime { get; set; }
        public string Name { get; } = "Стена";
        public int Prioritet { get; set; }
        private int x;
        private int y;
        public void Show()
        {
            BackgroundColor = ConsoleColor.White;
            SetCursorPosition(x, y - (BuiltingTime+1));
            for (int i = 0; i < 22; i++)
            {
                Write(" ");
                Thread.Sleep(70);
            }

            ResetColor();
        }
    }

}
