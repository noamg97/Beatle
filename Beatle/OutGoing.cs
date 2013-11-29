using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Beatle
{
    class OutGoing
    {
        private Socket s;
        public static MainForm parent;


        public void SendMessage(string msg, IPEndPoint partnerEndPoint)
        {
            if (Connect(partnerEndPoint))
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
                parent.WriteErrorToChat();
                return false;
            }
            return true;
        }
    }
}
