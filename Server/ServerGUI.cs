using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RadioButton = System.Windows.Forms.RadioButton;
using SMP_Library;
using Server;
using System.Threading;

namespace Server
{
    public partial class ServerGUI : Form
    {
        public int port = 50444;
        public ServerGUI()
        {
            InitializeComponent();
        }

        public void writeMessageToFile(SmpPacket packet)//, FileStream file)
        {
            byte[] messageTypeOut = new UTF8Encoding(true).GetBytes(packet.MessageType);
            byte[] priorityOut = new UTF8Encoding(true).GetBytes(packet.Priority);
            byte[] timeStampOut = new UTF8Encoding(true).GetBytes(packet.DateTime);
            byte[] messageOut = new UTF8Encoding(true).GetBytes(packet.Message);
            byte[] newLineOut = new UTF8Encoding(true).GetBytes("\n");
            MessageTextBox.Text = packet.Message;
            MessageTextBox.Text = "thing";
            /*file.Write(messageTypeOut, 0, messageTypeOut.Length);

            file.Write(newLineOut, 0, newLineOut.Length);
            file.Write(priorityOut, 0, priorityOut.Length);
            file.Write(timeStampOut, 0, timeStampOut.Length);
            file.Write(messageOut, 0, messageOut.Length);
            file.Write(newLineOut, 0, newLineOut.Length);
            file.Write(newLineOut, 0, newLineOut.Length);
            file.Flush();*/

        }
        private string getPriorityLevel()
        {
            if (LowPriorityRadioButton.Checked) {
                return "PRIORITY_LOW";
            } else if (MediumPriorityadioButton.Checked) {
                return "PRIORITY_MEDIUM";
            } else if (HighPriorityRadioButton.Checked) {
                return "PRIORITY_HIGH";
            } else {
                return "all";
            }
        }
        
        private void ShowMessagesButton_Click(object sender, EventArgs e)
        {
            ServerStatusTextBox.Text = String.Empty;
            
            string path = @"..\..\..\Messages.txt";

            string text = "";
            Boolean readLine = false;
            int messageLine = 0;
            string priority = getPriorityLevel();

            foreach (string line in File.ReadAllLines(path))
            {
                // handles when no priority is set
                if (string.Equals(priority, "all"))
                {
                    if (!String.Equals(line, "PutMessage"))
                    {
                        text += line + "\r\n";
                    }
                }

                else if (readLine)
                {
                    text += line+ "\r\n";
                    messageLine++;
                    if (messageLine == 4)
                    {
                        text += "\r\n";
                        messageLine = 0;
                        readLine = false;
                    }
                }

                else if (String.Equals(line, priority))
                {
                    readLine = true;
                    messageLine= 1;
                    text += line + "\r\n";
                } 

            }

            MessageTextBox.Text = text;
            if(MessageTextBox.Text == String.Empty)
            {
                ServerStatusTextBox.Text = "No messages with selected priority";
            }
            else
            {
                ServerStatusTextBox.Text = "Done.";
            }
        }

        

        private void AllPriorityRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PortNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            port = Int32.Parse(PortNumberTextBox.Text);
        }

        private void StartServerButton_Click(object sender, EventArgs e)
        {
            try
            {
                ThreadPool.QueueUserWorkItem(Server.Start, this);
                ServerStatusTextBox.Text = "Server Started...";
            }
            catch (Exception)
            {
                ServerStatusTextBox.Text = "Server Start error...";
            }
        }
    }
}
