using Microsoft.SqlServer.Server;
using SMP_Library;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace smpPacketUtil
{
    public static class SmpPacketUtil
    {
        public static string packetToString(SmpPacket packet)
        {
            return packet.MessageType + "\b" + packet.Priority + "\b" + packet.DateTime + "\b" + packet.Message;

        }

        public static SmpPacket StringToPacket(string str)
        {
            string[] splited = str.Split('\b');
            return new SmpPacket(splited[0], splited[1], splited[2], splited[3]);
        }
    }
}
