using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using SMP_Library;
using Sender;

namespace SMPProducer
{
    public partial class Producer : Form
    {
        public Producer()
        {
            InitializeComponent();
        }
        
        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            ProducerStatusBar.Text = String.Empty;

            String priority = "NONE";
            bool check = false;
            if (LowRadioButton.Checked)
            {
                check = true;
                priority = "PRIORITY_LOW";
            }
            else if (MediumRadioButton.Checked)
            {
                check = true;
                priority = "PRIORITY_MEDIUM";
            }
            else if (HighRadioButton.Checked)
            {
                check = true;
                priority = "PRIORITY_HIGH";
            }
            else
            {
                ProducerStatusBar.Text = "Please select priority.";
            }

            if (check)
            {
                DateTime date = DateTime.Today;
                TimeSpan time = DateTime.Now.TimeOfDay;

                if (MessageContentTextBox.Text != String.Empty)
                {
                    String timeStamp = "\n" + date.Month + "/" + date.Day + "/" + date.Year + " " + time.ToString(@"hh\:mm\:ss") + "\n";
                    SmpPacket packet = new SmpPacket("PutMessage", timeStamp, priority, MessageContentTextBox.Text);

                    try
                    {
                        string response = Client.SendPutMessage(ServerIPAddressTextBox.Text, Int32.Parse(ApplicationPortNumberTextBox.Text), packet);
                        ServerResponseTextBox.Text = response;
                        ProducerStatusBar.Text = "Message sent.";
                    } 
                    catch(Exception)
                    {
                        ProducerStatusBar.Text = "Please enter a valid IP address and port number";
                    }
                }
                else
                {
                    ProducerStatusBar.Text = "Please write message.";
                }

                MessageContentTextBox.Text = String.Empty;                   
            }
        }
    }
}
