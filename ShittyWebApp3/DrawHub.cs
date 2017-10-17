using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using ShittyWebApp3.Models;

namespace ShittyWebApp3
{
    public class DrawHub : Hub
    {
        static List<ApplicationUser> Users = new List<ApplicationUser>();

        public void Send(Data data, string group)
        {
            Clients.OthersInGroup(group).addLine(data);
        }

        public void Connect(string group)
        {
            var id = Context.ConnectionId;
            Groups.Add(id, group);
        }
    }
}