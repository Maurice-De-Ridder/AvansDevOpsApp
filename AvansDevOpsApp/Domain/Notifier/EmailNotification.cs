﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Notifier
{
    public class EmailNotification : INotification
    {
        public string Message(string notification)
        {
            return "Email: " + notification;
        }
    }
}
