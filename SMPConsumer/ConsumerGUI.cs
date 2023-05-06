using Sender;
using SMP_Library;
using smpPacketUtil;
using System;
using System.Windows.Forms;


namespace SMPConsumer
{
    public partial class ConsumerGUI : Form
    {
        
        public ConsumerGUI()
        {
            InitializeComponent();
        }

        private string GetPriorityLevel()
        {
            if (LowRadioButton.Checked)
            {
                return "PRIORITY_LOW";
            }
            else if (MediumRadioButton.Checked)
            {
                return "PRIORITY_MEDIUM";
            }
            else if (HighRadioButton.Checked)
            {
                return "PRIORITY_HIGH";
            }
            else
            {
                return "all";
            }
        }

        private void GetMessageButton_Click_1(object sender, EventArgs e)
        {
            string priority = GetPriorityLevel();
            if (string.Equals(priority, "all"))
            {
                ConsumerStatusBar.Text = "Please select prioirty.";
            } 
            else
            {
                if (String.IsNullOrEmpty(ServerIPAddressTextBox.Text) || String.IsNullOrEmpty(ApplicationPortNumberTextBox.Text))
                {
                    ConsumerStatusBar.Text = "Please enter a valid IP address and port number";
                } else
                {
                    try
                    {
                        string response = Client.SendGetRequest(ServerIPAddressTextBox.Text, Int32.Parse(ApplicationPortNumberTextBox.Text), priority);
                        SmpPacket packet = SmpPacketUtil.StringToPacket(response);
                        DisplaySmpPacket(SmpPacketUtil.StringToPacket(response));
                    }
                    catch (Exception)
                    {
                        ConsumerStatusBar.Text = "Please enter a valid IP address and port number";
                    }

                }
            }

        }

        private void DisplaySmpPacket(SmpPacket packet)
        {
            if (String.IsNullOrEmpty(packet.Message))
            {
                ConsumerStatusBar.Text = "No messages with selected priority.";
                MessageContentTextBox.Text = "";
            } 
            else
            {
                MessageContentTextBox.Text = packet.DateTime + '\n' + packet.Message;
                ConsumerStatusBar.Text = "";
            } 
        }
    }
}
