using System;
using static System.Console;
//using System.Collections.Generic;
using System.Threading;

namespace Sweet_House
{
    class Door : IPart
    {
        public Door(int installationTime, int prioritet, int posX, int posY)
        {
            InstallationTime = installationTime;
            Prioritet = prioritet;
            x = posX;
            y = posY;
        }
        public bool IsBuilt { get; set; } = false;
        public int InstallationTime { get; set; }
        public int BuiltingTime { get; set; }

        public string Name { get; } = "Дверь";
        public int Prioritet { get; set; }
        private int x;
        private int y;
        public void Show()
        {
            BackgroundColor = ConsoleColor.Cyan;

            for (int i = 0; i < 8; i++)
            {
                SetCursorPosition(x, y - i);
                for (int j = 0; j < 8; j++)
                {
                    Write(" ");
                    Thread.Sleep(70);
                }
            }
            BackgroundColor = ConsoleColor.Black;
            SetCursorPosition(x + 1, y - 4); Write(" ");
            
            ResetColor();
        }
    }

}
