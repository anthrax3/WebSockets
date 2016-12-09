﻿using System;
using System.Net.WebSockets;

namespace NetCoreStack.WebSockets.Internal
{
    public class WebSocketTransport : IDisposable
    {
        public WebSocket WebSocket { get; }
        public string ConnectionId { get; }

        public WebSocketTransport(WebSocket webSocket)
        {
            ConnectionId = Guid.NewGuid().ToString();
            WebSocket = webSocket;
        }

        public void Dispose()
        {
            WebSocket.Dispose();
        }
    }
}
