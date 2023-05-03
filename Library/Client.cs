using SMP_Library;
using System.Net;
using System.Net.Sockets;
using System.Text;
using smpPacketUtil;

namespace Sender
{
    public class Client
    {
        public static string SendPutMessage(string serverIpAddress, int port, SmpPacket message)
        {
            IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse(serverIpAddress), port);
            UdpClient client = new UdpClient();
            client.Connect(serverEndPoint);

            string strmesg = SmpPacketUtil.packetToString(message);
            byte[] sendbuf = Encoding.ASCII.GetBytes(strmesg);

            client.Send(sendbuf, sendbuf.Length);

            string response = ReceiveStatusMessage(client);
            return response;
        }

        public static string SendGetRequest(string serverIpAddress, int port, string priority)
        {
            IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse(serverIpAddress), port);
            UdpClient client = new UdpClient();
            client.Connect(serverEndPoint);

            string strmesg = "GetMessage" + priority;
            byte[] sendbuf = Encoding.ASCII.GetBytes(strmesg);

            client.Send(sendbuf, sendbuf.Length);

            string response = ReceiveStatusMessage(client);
            return response;
        }

        private static string ReceiveStatusMessage(UdpClient client)
        {
            IPEndPoint remoteIPEndPoint = new IPEndPoint(IPAddress.Any, 0);

            byte[] bytes = client.Receive(ref remoteIPEndPoint);

            string statusMessage = Encoding.ASCII.GetString(bytes, 0, bytes.Length);

            return statusMessage;
        }

    }
}
