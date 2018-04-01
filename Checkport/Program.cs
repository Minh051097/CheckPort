using System;
using System.Net;
using System.Net.Sockets;

namespace Checkport
{
    class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint ipserver = new IPEndPoint(IPAddress.Parse("74.125.24.186"), 81);
            /*TcpClient c = new TcpClient();
            c.ReceiveTimeout = 0;
            try
            {
                c.Connect(ipserver);
                Console.WriteLine(ipserver.ToString() + " is open");
                c.Close();
            }
            catch
            {
                Console.WriteLine(ipserver.ToString() + " is close");
            }*/
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            try
            {
                sock.Connect(ipserver);
                Console.WriteLine(ipserver.ToString() + "is open");
                sock.Close();
            }
            catch
            {
                Console.WriteLine(ipserver.ToString() + "is close");
            }
        }
    }
}
