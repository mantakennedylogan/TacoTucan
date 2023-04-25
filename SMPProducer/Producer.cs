using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using SMP_Library;


namespace SMPProducer
{
    public partial class Producer : Form
    {
        public Producer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ApplicationPortNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MessageContentLabel_Click(object sender, EventArgs e)
        {

        }
        private void writeMessageToFile(SmpPacket packet, FileStream file)
        {
            byte[] messageTypeOut = new UTF8Encoding(true).GetBytes(packet.MessageType);
            byte[] priorityOut = new UTF8Encoding(true).GetBytes(packet.Priority);
            byte[] timeStampOut = new UTF8Encoding(true).GetBytes(packet.DateTime);
            byte[] messageOut = new UTF8Encoding(true).GetBytes(packet.Message);
            byte[] newLineOut = new UTF8Encoding(true).GetBytes("\n");
            file.Write(messageTypeOut, 0, messageTypeOut.Length);
            file.Flush();
            file.Write(newLineOut, 0, newLineOut.Length);
            file.Flush();
            file.Write(priorityOut, 0, priorityOut.Length);
            file.Flush();
            file.Write(timeStampOut, 0, timeStampOut.Length);
            file.Flush();
            file.Write(messageOut, 0, messageOut.Length);
            file.Flush();
            file.Write(newLineOut, 0, newLineOut.Length);
            file.Flush();
            file.Write(newLineOut, 0, newLineOut.Length);
            file.Flush();
            
        }
        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            // TODO
            
            FileStream file;
            String path = @"../../../Messages.txt";
            MessageSentTextBox.Text = String.Empty;

            if (File.Exists(path))
            {
                file = File.Open(path, FileMode.Append);
            }
            else
            {
                file = File.Create(path);
            }
            using (file)
            {
                String message = MessageContentTextBox.Text;
                String priority = "NONE";
                bool check = false;
                if (LowRadioButton.Checked)
                {
                    LowRadioButton.Checked = false;
                    check = true;
                    priority = "PRIORITY_LOW";
                }
                else if (MediumRadioButton.Checked)
                {
                    MediumRadioButton.Checked = false; 
                    check = true;
                    priority = "PRIORITY_MEDIUM";
                }
                else if (HighRadioButton.Checked)
                {
                    HighRadioButton.Checked = false;    
                    check = true;
                    priority = "PRIORITY_HIGH";
                }
                else
                {
                    MessageSentTextBox.Text = "Please Select Priority";
                }

                if (check)
                {
                    DateTime date = DateTime.Today;
                    TimeSpan time = DateTime.Now.TimeOfDay;

                    if (MessageContentTextBox.Text != String.Empty)
                    {
                        String timeStamp = "\n" + date.Month + "/" + date.Day + "/" + date.Year + " " + time.ToString(@"hh\:mm\:ss") + "\n";
                        SmpPacket packet = new SmpPacket("PutMessage", timeStamp, priority, MessageContentTextBox.Text);
                        writeMessageToFile(packet, file);
                        MessageSentTextBox.Text = "Message Sent.";

                    }
                    else
                    {
                        MessageSentTextBox.Text = "Please Write Message";
                    }



                    MessageContentTextBox.Text = String.Empty;
                    file.Close();
                }
            }



        }

        private void LowRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
