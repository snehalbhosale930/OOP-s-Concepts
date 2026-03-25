using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPs__Concepts
{
    public class Notification
    {
        public virtual void SendNotification()
        {
            Console.WriteLine(" Test notification");
            Console.WriteLine("this is base class method and does not send any notification");
        }
    }

    public class SMS : Notification
    {
        public override void SendNotification()
        {
            Console.WriteLine("SMS is Sending");
            Console.WriteLine("SMS Sent");
        }
    }

    public class Email : Notification
    {
        public override void SendNotification()
        {
            Console.WriteLine("Email is Sending");
            Console.WriteLine("Email Sent");
        }
    }
}
