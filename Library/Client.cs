using SMP_Library;
using System.Net;
using System.Net.Sockets;
using System.Text;
using smpPacketUtil;

namespace Sender
{
    public class Client
    {
        public static void SendMessage(string serverIpAddress, int port, SmpPacket message)
        {
            IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse(serverIpAddress), port);

            UdpClient client = SendServerMessage(message, serverEndPoint);

            //string statusMessage = ReceiveStatusMessage(client);

            //ProcessServerStatusMessage(statusMessage);
        }

        private static UdpClient SendServerMessage(SmpPacket message, IPEndPoint serverEndPoint)
        {
            UdpClient client = new UdpClient();

            client.Connect(serverEndPoint);

            string strmesg = SmpPacketUtil.packetToString(message);

            byte[] sendbuf = Encoding.ASCII.GetBytes(strmesg);
            
            client.Send(sendbuf, sendbuf.Length);

            return client;
        }

        private static string ReceiveStatusMessage(UdpClient client)
        {
            IPEndPoint remoteIPEndPoint = new IPEndPoint(IPAddress.Any, 0);

            byte[] bytes = client.Receive(ref remoteIPEndPoint);

            string statusMessage = Encoding.ASCII.GetString(bytes, 0, bytes.Length);

            return statusMessage;
        }

        private static void ProcessServerStatusMessage(string serverResponse)
        {
            //form.RecordServerResponse(serverResponse);
        }
    }
}
