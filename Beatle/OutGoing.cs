using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Beatle
{
    class OutGoing
    {
        private Socket s;
        public static MainForm parent;
        public static bool isExiting = false;

        public void SendMessage(string msg, IPEndPoint partnerEndPoint)
        {
            if (Connect(partnerEndPoint))
            {
                if (!isExiting)
                {
                    s.Send(Encoding.ASCII.GetBytes(msg), SocketFlags.None);

                    byte[] buffer = new byte[s.SendBufferSize];
                    int bytesRecieved = s.Receive(buffer);

                    byte[] formatted = new byte[bytesRecieved];

                    for (int i = 0; i < formatted.Length; i++)
                        formatted[i] = buffer[i];

                    string strData = Encoding.ASCII.GetString(formatted);

                    parent.WriteRecievedSymboleToChat();
                }
            }
            if (s.Connected) s.Close();
            s.Dispose();
        }

        private bool Connect(IPEndPoint partnerEndPoint)
        {
            try
            {
                s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                s.Connect(partnerEndPoint);
            }
            catch
            {
                //parent.WriteErrorToChat();
                if (!isExiting)
                    Connect(partnerEndPoint);
            }
            return true;
        }
    }
}
