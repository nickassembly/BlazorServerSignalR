using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace BlazorServer.Hubs;
public class CounterHub : Hub
{
    public Task AddToTotal(string user, int value)
    {
        return Clients.All.SendAsync("CounterIncrement", user, value);
    }
    
}
