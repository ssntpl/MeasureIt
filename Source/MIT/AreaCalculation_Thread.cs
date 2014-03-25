using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;

namespace mit
{
    class AreaCalculation_Thread
    {

         public int count;
        public Thread thrd;

        public AreaCalculation_Thread()
        {
            
            thrd = new Thread(this.run);
            thrd.Start();
        }
        void run()
        {
           // Console.WriteLine("Starting Thread");
           
            while (!Commonforallfunctions.getcancelbool())//till cancel button/tool is not clicked
            {
                //Console.WriteLine("Inside Area Thread");
                if (Commonforallfunctions.getclickbool())
                {
                    
                    Console.WriteLine("Click Bool value: " + Commonforallfunctions.getclickbool() + Commonforallfunctions.getRecordpointsbool());
                    Console.WriteLine("Count now: " + count);
                    Commonforallfunctions.setclickbool(false);//reset the value of click_detected
                   

                }
            }
            Commonforallfunctions.setdrawbool(false);//both the points collected
            Commonforallfunctions.setcalculationthread_finishbool(true);
            Commonforallfunctions.setRecordpointsbool(false);
            Console.WriteLine("Thread Ended");
        }
    }
}
