using SMP_Library;
using smpPacketUtil;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;


namespace Server
{
    public class Server
    {
        static UdpClient server;
        static ServerGUI serverForm;
        
        public static void Start(object obj)
        {
            serverForm = obj as ServerGUI;

            server = new UdpClient(serverForm.port);

            try
            {
                while (true)
                {
                    string message = ReceiveClientMessage(out IPEndPoint remoteIpEndPoint);

                    SmpPacket packet = SmpPacketUtil.StringToPacket(message);
                    serverForm.writeMessageToFile(packet);
                    //ProcessClientMessage(message);

                    SendStatusMessage("Server: Message recorded...", remoteIpEndPoint);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private static string ReceiveClientMessage(out IPEndPoint remoteIpEndPoint)
        {
            remoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);

            byte[] bytes = server.Receive(ref remoteIpEndPoint);

            string message = Encoding.ASCII.GetString(bytes, 0, bytes.Length);

            return message;
        }

        /*private static void ProcessClientMessage(string message)
        {
            serverForm.RecordClientMessage(message);
        }*/

        public static void SendStatusMessage(string statusMessage, IPEndPoint remoteIpEndPoint)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(statusMessage);

            server.Send(bytes, bytes.Length, remoteIpEndPoint);
        }
    }
}
