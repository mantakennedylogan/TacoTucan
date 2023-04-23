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
            string priority = getPriorityLevel();

            foreach (string line in File.ReadAllLines(path))
            {
                // handles when no priority is set
                if (string.Equals(priority, "all"))
                {
                    if (!string.Equals(line, "PRIORITY_LOW") && !string.Equals(line, "PRIORITY_MEDIUM") && !string.Equals(line, "PRIORITY_HIGH"))
                    {
                        text += line + "\r\n";
                    }
                }

                else if (readLine)
                {
                    text += line+ "\r\n\r\n";                 
                    readLine = false;
                }

                else if (String.Equals(line, priority))
                {
                    readLine = true;   
                } 

            }

            MessageTextBox.Text = text;
        }
    }
}
