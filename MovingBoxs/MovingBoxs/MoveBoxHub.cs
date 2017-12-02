using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovingBoxs
{
    public class MoveBoxHub : Hub
    {

        public void Move(int x,int y)
        {
            Clients.All.MoveIt(x, y);
        }
    }
}