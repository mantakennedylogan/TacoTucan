using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RadioButton = System.Windows.Forms.RadioButton;

namespace SMPConsumer
{
    public partial class ConsumerGUI : Form
    {
        
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
            string[] fileStrings = File.ReadAllLines(path);
            for (int i = 0; i < fileStrings.Length; i++)
            {
                string line = fileStrings[i];
                // handles when no priority is set
                if (string.Equals(priority, "all"))
                {
                    text = "NO SELECTION";
                } 

                if (readLine == true)
                {
                    linesread += 1;
                    text += line + "\r\n";
                    fileStrings = remove_from_array(fileStrings, i);
                    i--;
                    if (linesread == 2)
                    {
                        fileStrings = remove_from_array(fileStrings, i + 1);
                        break;
                    }
                }

                if (string.Equals(priority, "PRIORITY_LOW"))
                {
                    if (string.Equals(line, "PRIORITY_LOW"))
                    {
                        readLine = true;
                        fileStrings = remove_from_array(fileStrings, i);
                        i--;
                        fileStrings = remove_from_array(fileStrings, i);
                        i--;
                    }
                }

                if (string.Equals(priority, "PRIORITY_MEDIUM"))
                {
                    if (string.Equals(line, "PRIORITY_MEDIUM"))
                    {
                        readLine = true;
                        fileStrings = remove_from_array(fileStrings, i);
                        i--;
                        fileStrings = remove_from_array(fileStrings, i);
                        i--;
                    }
                }

                if (string.Equals(priority, "PRIORITY_HIGH"))
                {
                    if (string.Equals(line, "PRIORITY_HIGH"))
                    {
                        readLine = true;
                        fileStrings = remove_from_array(fileStrings, i);
                        i--;
                        fileStrings = remove_from_array(fileStrings, i);
                        i--;
                    }
                }
            }
            File.WriteAllLines(path, fileStrings);
            if (text == "")
            {
                text = "no message";
            }

            MessageContentTextBox.Text = text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private string[] remove_from_array(string[] array, int index)
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

                if (passedIndex && i != index) {
                    newarray[i - 1] = array[i]; 
                } else if (i != index) {
                    newarray[i] = array[i];
                }
            }
            return newarray;
        }

        private void LowRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
