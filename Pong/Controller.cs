using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Controller
    {
        public static ConsoleKey keyPressed;


        public static void keyPressedEvent(object sender, DoWorkEventArgs e)
        {
          

            do
            {
                Update.keyinfo = Console.ReadKey(true);
                keyPressed = Update.keyinfo.Key;
             
            } while (Update.keyinfo.Key != ConsoleKey.X);

            
        }

        
    }
}
