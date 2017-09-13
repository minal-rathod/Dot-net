using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification
{
    class Notify
    {
       public virtual void notify() { }
       
    }

    class Email :Notify
    {
        public override void notify()
       {
            Console.WriteLine("Email sent.");
            Console.ReadLine();
        }
    }

    class Sms :Notify
    {
        public override void notify()
        {
            Console.WriteLine("Sms sent.");
            Console.ReadLine();
        }
    }
}
