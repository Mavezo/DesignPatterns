using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Structural.Bridge.Notifications
{
	public class UrgentNotification : Notification
	{
		public UrgentNotification(INotificationSender notificationSender) : base(notificationSender)
		{
		}
		public override void Notify(string message)
		{
			this.notificationSender.Send(message);
		}
	}

}
