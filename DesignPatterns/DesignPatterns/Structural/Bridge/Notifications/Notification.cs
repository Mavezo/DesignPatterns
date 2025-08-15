using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Bridge.Notifications
{
    public class Notification
    {
        protected readonly INotificationSender notificationSender;

        public Notification(INotificationSender notificationSender)
        {
            this.notificationSender = notificationSender;
        }

        public virtual void Notify(string message)
        {
            notificationSender.Send(message);
        }
    }
}
