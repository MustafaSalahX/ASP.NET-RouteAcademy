using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShopTwoOOP3.Interfaces;

namespace WorkShopTwoOOP3.Classes
{
    public class EmailNotificationService : INotificationService
    {
        public void SendNotification(string recipent, string message)
        {
            Console.WriteLine("Sending Email Notification");
            Console.WriteLine($"To {recipent}");
            Console.WriteLine($"Message -> {message}");
        }
    }
}
