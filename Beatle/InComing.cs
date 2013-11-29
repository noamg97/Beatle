using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;


namespace Beatle
{
    class InComing
    {
        private byte[] buffer;
        private int port = 1998;
        public static event MessegeAdded messegeAddedEvent;

        
        public void Listen()
        {
            try
            {
                using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
                {
                    socket.Bind(new IPEndPoint(IPAddress.Any, port));

                    socket.Listen(100);

                    while (true)
                        using (var accepted = socket.Accept())
                        {
                            buffer = new byte[accepted.SendBufferSize];
                            int bytesRecieved = accepted.Receive(buffer);

                            byte[] formatted = new byte[bytesRecieved];

                            for (int i = 0; i < formatted.Length; i++)
                                formatted[i] = buffer[i];

                            string strData = Encoding.ASCII.GetString(formatted);

                            messegeAddedEvent.Invoke(strData + "\r\n", "Partner");

                            accepted.Send(Encoding.ASCII.GetBytes("[R]"));
                        }
                }
            }
            catch
            {
            }
        }
    }
}
