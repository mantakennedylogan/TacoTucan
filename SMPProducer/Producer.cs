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
        
        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            
            FileStream file;
            String path = @"../../../Messages.txt";
            ProducerStatusBar.Text = String.Empty;

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

                        //TODO
                        //try catch here
                        Client.SendMessage(ServerIPAddressTextBox.Text, Int32.Parse(ApplicationPortNumberTextBox.Text), packet);


                        ProducerStatusBar.Text = "Message sent.";

                    }
                    else
                    {
                        ProducerStatusBar.Text = "Please write message.";
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
