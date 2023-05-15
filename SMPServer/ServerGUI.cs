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
using System.Net.Sockets;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Server
{
    public partial class ServerGUI : Form
    {
        public int port;
        public ServerGUI()
        {
            InitializeComponent();
        }

        private void StartServerButton_Click(object sender, EventArgs e)
        {
            try
            {
                ThreadPool.QueueUserWorkItem(Server.Start, this);
                port = Int32.Parse(PortNumberTextBox.Text);
                ServerStatusTextBox.Text = "Server Started...";
                StartServerButton.Enabled = false;
            }
            catch (Exception)
            {
                ServerStatusTextBox.Text = "Server Start error...";
            }


        }
        public void WriteMessageToFile(SmpPacket packet)
        {
            FileStream file = File.Open(@"..\..\..\Messages.txt", FileMode.Append);
            byte[] messageTypeOut = new UTF8Encoding(true).GetBytes(packet.MessageType);
            byte[] priorityOut = new UTF8Encoding(true).GetBytes(packet.Priority);
            byte[] timeStampOut = new UTF8Encoding(true).GetBytes(packet.DateTime);
            byte[] messageOut = new UTF8Encoding(true).GetBytes(packet.Message);
            byte[] newLineOut = new UTF8Encoding(true).GetBytes("\n");

            file.Write(messageTypeOut, 0, messageTypeOut.Length);
            file.Write(newLineOut, 0, newLineOut.Length);
            file.Write(priorityOut, 0, priorityOut.Length);
            file.Write(timeStampOut, 0, timeStampOut.Length);
            file.Write(messageOut, 0, messageOut.Length);
            file.Write(newLineOut, 0, newLineOut.Length);
            file.Write(newLineOut, 0, newLineOut.Length);
            file.Flush();
            file.Close();

            UpdateLastReceivedMessageType("PUT");
            UpdateLastReceivedMessagePriority(packet.Priority);
        }

        public SmpPacket GetMessageFromFile(string priority)
        {
            string path = @"..\..\..\Messages.txt";

            string text = "";
            Boolean readLine = false;
            int linesread = 0;
            string[] fileStrings = File.ReadAllLines(path);
            for (int i = 0; i < fileStrings.Length; i++)
            {
                string line = fileStrings[i];

                if (readLine == true)
                {
                    linesread += 1;
                    text += line + "\r\n";
                    fileStrings = Remove_from_array(fileStrings, i);
                    i--;
                    if (linesread == 2)
                    {
                        fileStrings = Remove_from_array(fileStrings, i + 1);
                        break;
                    }
                }

                if (string.Equals(priority, "PRIORITY_LOW"))
                {
                    if (string.Equals(line, "PRIORITY_LOW"))
                    {
                        readLine = true;
                        fileStrings = Remove_from_array(fileStrings, i);
                        i--;
                        fileStrings = Remove_from_array(fileStrings, i);
                        i--;
                    }
                }

                if (string.Equals(priority, "PRIORITY_MEDIUM"))
                {
                    if (string.Equals(line, "PRIORITY_MEDIUM"))
                    {
                        readLine = true;
                        fileStrings = Remove_from_array(fileStrings, i);
                        i--;
                        fileStrings = Remove_from_array(fileStrings, i);
                        i--;
                    }
                }

                if (string.Equals(priority, "PRIORITY_HIGH"))
                {
                    if (string.Equals(line, "PRIORITY_HIGH"))
                    {
                        readLine = true;
                        fileStrings = Remove_from_array(fileStrings, i);
                        i--;
                        fileStrings = Remove_from_array(fileStrings, i);
                        i--;
                    }
                }

            }

            File.WriteAllLines(path, fileStrings);

            string[] packetItems = text.Split('\n');
            SmpPacket returnPacket;

            if (text == "")
            {
                returnPacket = new SmpPacket("Getmessage", packetItems[0], priority, "");
            } 
            else
            {
                returnPacket = new SmpPacket("Getmessage", packetItems[0], priority, packetItems[1]);
            }

            UpdateLastReceivedMessageType("GET");
            UpdateLastReceivedMessagePriority(priority);
            return returnPacket;
        }

        private string[] Remove_from_array(string[] array, int index)
        {
            string[] newarray;
            if (array.Length - 1 <= 0)
            {
                newarray = new string[0];
                return newarray;
            }

            newarray = new string[array.Length - 1];
            Boolean passedIndex = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == index)
                {
                    passedIndex = true;
                }

                if (passedIndex && i != index)
                {
                    newarray[i - 1] = array[i];
                }
                else if (i != index)
                {
                    newarray[i] = array[i];
                }
            }
            return newarray;
        }

        private string GetPriorityLevel()
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
            string priority = GetPriorityLevel();

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
            if(MessageTextBox.Text == String.Empty && LowPriorityRadioButton.Checked)
            {
                ServerStatusTextBox.Text = "No messages with low priority.";
                return;
            }
            else if (MessageTextBox.Text == String.Empty && MediumPriorityadioButton.Checked)
            {
                ServerStatusTextBox.Text = "No messages with medium priority.";
                return;
            }
            else if (MessageTextBox.Text == String.Empty && HighPriorityRadioButton.Checked)
            {
                ServerStatusTextBox.Text = "No messages with high priority.";
                return;
            }
            else if (MessageTextBox.Text == String.Empty && AllPriorityRadioButton.Checked)
            {
                ServerStatusTextBox.Text = "No messages.";
                return;
            }
            else
            {
                ServerStatusTextBox.Text = "Done.";
                return;
            }
        }

        private void PortNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            port = Int32.Parse(PortNumberTextBox.Text);
        }

        private delegate void SafeCallDelegate(string type);
        private void UpdateLastReceivedMessageType(string type)
        {
            if (MessageTypeTextBox.InvokeRequired)
            {
                var d = new SafeCallDelegate(UpdateLastReceivedMessageType);
                MessageTypeTextBox.Invoke(d, new object[] { type });
            }
            else
            {
                MessageTypeTextBox.Text = type;
            }
        }

        private delegate void SafeCallDelegate2(string type);
        private void UpdateLastReceivedMessagePriority(string priority)
        {
            if (MessagePriorityTextbox.InvokeRequired)
            {
                var d = new SafeCallDelegate2(UpdateLastReceivedMessagePriority);
                MessagePriorityTextbox.Invoke(d, new object[] { priority });
            }
            else
            {
                MessagePriorityTextbox.Text = priority;
            }
        }

        

    }
}
