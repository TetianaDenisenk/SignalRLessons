using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace MovingBoxs
{
    [HubName("moveBoxHub")]
    public class MoveBoxHub : Hub
    {
        static int x =1;
        static int y=10;
        public void Move()
        {
            x += 1;
            y += 1;
            Clients.All.MoveIt(x, y);
        }
        public override Task OnDisconnected(bool stopCalled)
        {
            x -= 100;
            return base.OnDisconnected(stopCalled);
        }
    }
}