using System;
using static System.Console;
//using System.Collections.Generic;
using System.Threading;

namespace Sweet_House
{
    class Roof : IPart
    {
        public Roof(int installationTime, int prioritet, int posX, int posY)
        {
            InstallationTime = installationTime;
            Prioritet = prioritet;
            x = posX;
            y = posY;
        }

        public bool IsBuilt { get; set; } = false;
        public int InstallationTime { get; set; }
        public int BuiltingTime { get; set; }
        public string Name { get; } = "Крыша";
        public int Prioritet { get; set; }
        private int x;
        private int y;
        public void Show()
        {
            BackgroundColor = ConsoleColor.Red;
            ForegroundColor = ConsoleColor.Black;
            SetCursorPosition(x + BuiltingTime, y - BuiltingTime);
            for (int i = 0; i < (93 - (BuiltingTime * 2)); i++)
            {
                Write("_");



                Thread.Sleep(70);
            }

            ResetColor();
        }
    }
}
