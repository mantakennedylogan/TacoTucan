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
                    string messageRequestType = message.Substring(0, 10);

                    // PUT request
                    if (String.Equals(messageRequestType, "PutMessage"))
                    {
                        SmpPacket packet = SmpPacketUtil.StringToPacket(message);                    
                        serverForm.WriteMessageToFile(packet);

                        string mesageReceivedconfirmation = "Message recorded: " + DateTime.Now.ToString("M/dd/yyyy HH:mm:ss");
                        byte[] bytes = Encoding.ASCII.GetBytes(mesageReceivedconfirmation);
                        
                        server.Send(bytes, bytes.Length, remoteIpEndPoint);
                    } 
                    // GET request
                    else
                    {
                        string priority = message.Substring(10);

                        SmpPacket returnPacket = serverForm.GetMessageFromFile(priority);
                        string smpPacketAsString = SmpPacketUtil.packetToString(returnPacket);
                        byte[] bytes = Encoding.ASCII.GetBytes(smpPacketAsString);

                        server.Send(bytes, bytes.Length, remoteIpEndPoint);
                    }        
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
    }
}
