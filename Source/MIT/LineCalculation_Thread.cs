using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace mit
{
    class LineCalculation_Thread
    {
        public int count;
        public Thread thrd;

        public LineCalculation_Thread()
        {
            count = 0;
            thrd = new Thread(this.run);
            thrd.Start();
        }
        void run()
        {
            Console.WriteLine("Starting Thread");
            //Commonforallfunctions.setRecordpointsbool(true);//to indicate that points clicked are to be recorded in list.
            Console.WriteLine("CANCEL VALU IS CANCEL CLICKED: "+Commonforallfunctions.getcancelbool());
            while ((count < 2))//since only 2 points are required and cancel button/tool is not clicked
            {
                if (Commonforallfunctions.getclickbool())
                {
                    count++;
                    Console.WriteLine("Click Bool value: " + Commonforallfunctions.getclickbool() + Commonforallfunctions.getRecordpointsbool());
                    Console.WriteLine("Count now: " + count);
                    Commonforallfunctions.setclickbool(false);//reset the value of click_detected
                   

                }
                if (Commonforallfunctions.getcancelbool())
                {
                    Console.WriteLine("CANCEL VALU IS CANCEL CLICKED: " + Commonforallfunctions.getcancelbool());
                    Commonforallfunctions.setcancelbool(false);
                    Console.WriteLine("CANCEL VALU IS CANCEL CLICKEDafter setting to false: " + Commonforallfunctions.getcancelbool());
                    break;
                }
            }
            Commonforallfunctions.setdrawbool(false);//both the points collected
            Commonforallfunctions.setcalculationthread_finishbool(true);
            Commonforallfunctions.setRecordpointsbool(false);
            Console.WriteLine("Thread Ended");
        }
    }
}

