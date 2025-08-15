using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Bridge.Notifications
{
	public class ScheduledNotification : Notification
	{
		protected readonly DateTime scheduledTime;
		public ScheduledNotification(INotificationSender notificationSender, DateTime scheduledTime) : base(notificationSender)
		{
			this.scheduledTime = scheduledTime;
		}
		public override void Notify(string message) {
            Console.WriteLine($"Scheduled for {scheduledTime.ToShortDateString()}");
            notificationSender.Send(message);
		}
	}
}
