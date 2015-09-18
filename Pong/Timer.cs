using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Pong
{
    class Timer
    {
        [DllImport("kernel32.dll")]
        private static extern long GetTickCount();

        private static long StartTick = 0;

        public Timer()
        {
            Reset();
        }

        public static void Reset()
        {
            StartTick = GetTickCount();
        }

        public static long GetTicks()
        {
            long currentTick = 0;
            currentTick = GetTickCount();

            return currentTick - StartTick;
        }


        public static void GameLoop()
        {
            Update.running = true;
            while (true)
            {
               Reset();
              
                while (GetTicks() < 50) ;
                Update.logic();
        
            }
        }

    }
}
