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

namespace SMPConsumer
{
    public partial class ConsumerGUI : Form
    {
        private int lowCount = 1;
        private int highCount = 1;
        private int mediumCount = 1;
        private int allCount = 1;
        public ConsumerGUI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
      
        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

            string path = @"..\..\..\Messages.txt";

            string text = "";
            Boolean readLine = false;
            string priority = GetPriorityLevel();
            int linesread = 0;
            int times = 0;
            foreach (string line in File.ReadAllLines(path))
            {
                // handles when no priority is set
                if (string.Equals(priority, "all"))
                {
                    text = "NO SELECTION";
                } 

                if (readLine == true)
                {
                    linesread += 1;
                    text += line + "\r\n";
                    if (linesread == 2)
                    {
                        break;
                    }
                }

                if (string.Equals(priority, "PRIORITY_LOW"))
                {
                    if (string.Equals(line, "PRIORITY_LOW"))
                    {
                        times += 1;
                        if (times == lowCount)
                        {
                            lowCount += 1;
                            readLine = true;
                        }
                    }
                }

                if (string.Equals(priority, "PRIORITY_MEDIUM"))
                {
                    if (string.Equals(line, "PRIORITY_MEDIUM"))
                    {
                        times += 1;
                        if (times == mediumCount)
                        {
                            mediumCount += 1;
                            readLine = true;
                        }
                    }
                }

                if (string.Equals(priority, "PRIORITY_HIGH"))
                {
                    if (string.Equals(line, "PRIORITY_HIGH"))
                    {
                        times += 1;
                        if (times == highCount)
                        {
                            highCount += 1;
                            readLine = true;
                        }
                    }
                }
            }

            if (text == "")
            {
                text = "no message";
                if (string.Equals(priority, "PRIORITY_LOW"))
                {
                    lowCount = 1;
                }
                else if (string.Equals(priority, "PRIORITY_MEDIUM"))
                {
                    mediumCount = 1;
                }
                else if (string.Equals(priority, "PRIORITY_HIGH"))
                {
                    highCount = 1;
                }
                else if (string.Equals(priority, "all"))
                {
                    allCount = 1;
                }
            }
            MessageContentTextBox.Text = text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
