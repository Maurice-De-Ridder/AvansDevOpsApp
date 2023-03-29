﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Notifier
{
    public class SlackNotification : INotification
    {
        public string message(string notification)
        {
            return "Slack: " + notification;
        }
    }
}
