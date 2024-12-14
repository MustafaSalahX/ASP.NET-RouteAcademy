﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShopTwoOOP3.Interfaces
{
	public interface INotificationService
	{
		void SendNotification(string recipent, string message);
	}
}
