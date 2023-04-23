namespace SMP_Library
{
    public class SmpPacket
    {
        public string MessageType;
        public string DateTime;
        public string Priority;
        public string Message;

        public SmpPacket(string messageType, string dateTime, string priority, string message)
        {
            MessageType = messageType;
            DateTime = dateTime;
            Priority = priority;
            Message = message;
        }
    }
}
