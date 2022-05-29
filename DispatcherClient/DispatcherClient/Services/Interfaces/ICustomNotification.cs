using System;
using System.Collections.Generic;
using System.Text;

namespace DispatcherClient.Services.Interfaces
{
    public interface ICustomNotification
    {
        void Send(string title, string message);
    }
}
