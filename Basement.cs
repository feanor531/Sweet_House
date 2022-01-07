using System;
using static System.Console;
//using System.Collections.Generic;
using System.Threading;

namespace Sweet_House
{
    class Basement : IPart
    {
        public Basement(int installationTime, int prioritet, int posX, int posY)
        {
            InstallationTime = installationTime;
            Prioritet = prioritet;
            x = posX;
            y = posY;
        }

        public bool IsBuilt { get; set; } = false;
        public int InstallationTime { get; set; }
        public int BuiltingTime { get; set; }
        public string Name { get; } = "Фундамент";
        public int Prioritet { get; set; }
        private int x;
        private int y;

        public void Show()
        {
            BackgroundColor = ConsoleColor.DarkGray;
            SetCursorPosition(x + (BuiltingTime-1)*31, y);
            for (int i = 0; i < 32; i++)
            {                
                Write(" ");
                Thread.Sleep(70);
            }           
            
            ResetColor();
        }
    }
}
