using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRExample.Hubs
{
    public class ChatHub : Hub
    {
        public void Send(string userName, string message)
        {
            string timeNow = DateTime.Now.Hour + ":" + DateTime.Now.Minute.ToString("D2") + ":" + DateTime.Now.Second.ToString("D2");
            // Call the addNewMessageToPage method to update clients.
            Clients.All.addNewMessageToPage(userName, message, timeNow);
        }
    }
}