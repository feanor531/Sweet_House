using System;
using static System.Console;
//using System.Collections.Generic;
using System.Threading;

namespace Sweet_House
{
    class Window : IPart
    {
        public Window(int installationTime, int prioritet, int posX, int posY, string name)
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
        public string Name { get; }
        public int Prioritet { get; set; }
        private int x;
        private int y;
        public void Show()
        {
            BackgroundColor = ConsoleColor.Green;
            
            for (int i = 0; i < 5; i++)
            {
                SetCursorPosition(x, y-i);
                for (int j = 0; j < 8; j++)
                {
                    Write(" ");
                    Thread.Sleep(70);
                }
            }
            BackgroundColor = ConsoleColor.Blue;
            SetCursorPosition(x+1, y-1); Write("  ");
            SetCursorPosition(x+5, y-1); Write("  ");
            SetCursorPosition(x+1, y-3); Write("  ");
            SetCursorPosition(x+5, y-3); Write("  ");
            ResetColor();
        }
    }
}
