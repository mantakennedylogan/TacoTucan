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

namespace Server
{
    public partial class ServerGUI : Form
    {
        public ServerGUI()
        {
            InitializeComponent();
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
        }

        private void AllPriorityRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
