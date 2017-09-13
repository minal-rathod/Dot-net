using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Notify Nobj = new Email();
            Nobj.notify();*/

            Notify Mobj = new Sms();
            Mobj.notify();
        }
    }
}
