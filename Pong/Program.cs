using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pong
{
    class Program
    {
        static void Main(string[] args)
        {

            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += new DoWorkEventHandler(Controller.keyPressedEvent);
            bw.RunWorkerAsync();
            Console.SetWindowSize(100, 30);

            Timer.GameLoop();
           





            Console.ReadLine();
        }


       
    }
}
