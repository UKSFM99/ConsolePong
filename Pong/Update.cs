using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Update {


     
        public static ConsoleKeyInfo keyinfo;
        public static bool running;

        public static int x = 0;


        public static void logic() {

            if (Controller.keyPressed == ConsoleKey.S)
            {
                x++;
            }

            Console.Clear();
            drawRect(2, 10, 0, x);
            
        }
      


    


        public static void drawRect(int width, int length, int xPos, int yPos) {

            for (int w = 0; w < width; w++) {

                for (int l = 0; l < length; l++)
                {
                    Console.SetCursorPosition(w+xPos, l+yPos);
                    Console.Write("#");
                }
            
            }
        
        }

    }
}
