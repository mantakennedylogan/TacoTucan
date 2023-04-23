namespace SMPProducer
{
    partial class Producer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.ApplicationPortNumberTextBox = new System.Windows.Forms.TextBox();
            this.ApplicationPortNumberLabel = new System.Windows.Forms.Label();
            this.ServerIPAddressTextBox = new System.Windows.Forms.TextBox();
            this.ServerIPAddressLabel = new System.Windows.Forms.Label();
            this.ServerResponseLabel = new System.Windows.Forms.Label();
            this.ServerResponseTextBox = new System.Windows.Forms.TextBox();
            this.MessageGroupBox = new System.Windows.Forms.GroupBox();
            this.SendMessageButton = new System.Windows.Forms.Button();
            this.MessageContentLabel = new System.Windows.Forms.Label();
            this.MessageContentTextBox = new System.Windows.Forms.TextBox();
            this.PPriortyGroupBox = new System.Windows.Forms.GroupBox();
            this.HighRadioButton = new System.Windows.Forms.RadioButton();
            this.MediumRadioButton = new System.Windows.Forms.RadioButton();
            this.LowRadioButton = new System.Windows.Forms.RadioButton();
            this.SettingsGroupBox.SuspendLayout();
            this.MessageGroupBox.SuspendLayout();
            this.PPriortyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsGroupBox
            // 
            this.SettingsGroupBox.Controls.Add(this.ApplicationPortNumberTextBox);
            this.SettingsGroupBox.Controls.Add(this.ApplicationPortNumberLabel);
            this.SettingsGroupBox.Controls.Add(this.ServerIPAddressTextBox);
            this.SettingsGroupBox.Controls.Add(this.ServerIPAddressLabel);
            this.SettingsGroupBox.Location = new System.Drawing.Point(16, 15);
            this.SettingsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SettingsGroupBox.Size = new System.Drawing.Size(665, 65);
            this.SettingsGroupBox.TabIndex = 0;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "Settings";
            // 
            // ApplicationPortNumberTextBox
            // 
            this.ApplicationPortNumberTextBox.Location = new System.Drawing.Point(491, 23);
            this.ApplicationPortNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ApplicationPortNumberTextBox.Name = "ApplicationPortNumberTextBox";
            this.ApplicationPortNumberTextBox.Size = new System.Drawing.Size(109, 22);
            this.ApplicationPortNumberTextBox.TabIndex = 3;
            this.ApplicationPortNumberTextBox.TextChanged += new System.EventHandler(this.ApplicationPortNumberTextBox_TextChanged);
            // 
            // ApplicationPortNumberLabel
            // 
            this.ApplicationPortNumberLabel.AutoSize = true;
            this.ApplicationPortNumberLabel.Location = new System.Drawing.Point(321, 31);
            this.ApplicationPortNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ApplicationPortNumberLabel.Name = "ApplicationPortNumberLabel";
            this.ApplicationPortNumberLabel.Size = new System.Drawing.Size(152, 16);
            this.ApplicationPortNumberLabel.TabIndex = 2;
            this.ApplicationPortNumberLabel.Text = "Application Port Number";
            this.ApplicationPortNumberLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // ServerIPAddressTextBox
            // 
            this.ServerIPAddressTextBox.Location = new System.Drawing.Point(151, 27);
            this.ServerIPAddressTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ServerIPAddressTextBox.Name = "ServerIPAddressTextBox";
            this.ServerIPAddressTextBox.Size = new System.Drawing.Size(143, 22);
            this.ServerIPAddressTextBox.TabIndex = 1;
            // 
            // ServerIPAddressLabel
            // 
            this.ServerIPAddressLabel.AutoSize = true;
            this.ServerIPAddressLabel.Location = new System.Drawing.Point(20, 31);
            this.ServerIPAddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServerIPAddressLabel.Name = "ServerIPAddressLabel";
            this.ServerIPAddressLabel.Size = new System.Drawing.Size(116, 16);
            this.ServerIPAddressLabel.TabIndex = 0;
            this.ServerIPAddressLabel.Text = "Server IP Address";
            this.ServerIPAddressLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ServerResponseLabel
            // 
            this.ServerResponseLabel.AutoSize = true;
            this.ServerResponseLabel.Location = new System.Drawing.Point(13, 91);
            this.ServerResponseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServerResponseLabel.Name = "ServerResponseLabel";
            this.ServerResponseLabel.Size = new System.Drawing.Size(113, 16);
            this.ServerResponseLabel.TabIndex = 1;
            this.ServerResponseLabel.Text = "Server Response";
            // 
            // ServerResponseTextBox
            // 
            this.ServerResponseTextBox.Location = new System.Drawing.Point(183, 87);
            this.ServerResponseTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ServerResponseTextBox.Name = "ServerResponseTextBox";
            this.ServerResponseTextBox.Size = new System.Drawing.Size(459, 22);
            this.ServerResponseTextBox.TabIndex = 4;
            // 
            // MessageGroupBox
            // 
            this.MessageGroupBox.Controls.Add(this.SendMessageButton);
            this.MessageGroupBox.Controls.Add(this.MessageContentLabel);
            this.MessageGroupBox.Controls.Add(this.MessageContentTextBox);
            this.MessageGroupBox.Controls.Add(this.PPriortyGroupBox);
            this.MessageGroupBox.Location = new System.Drawing.Point(20, 119);
            this.MessageGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MessageGroupBox.Name = "MessageGroupBox";
            this.MessageGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MessageGroupBox.Size = new System.Drawing.Size(661, 258);
            this.MessageGroupBox.TabIndex = 5;
            this.MessageGroupBox.TabStop = false;
            this.MessageGroupBox.Text = "Message";
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.Location = new System.Drawing.Point(191, 213);
            this.SendMessageButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(432, 31);
            this.SendMessageButton.TabIndex = 6;
            this.SendMessageButton.Text = "Send Message";
            this.SendMessageButton.UseVisualStyleBackColor = true;
            this.SendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // MessageContentLabel
            // 
            this.MessageContentLabel.AutoSize = true;
            this.MessageContentLabel.Location = new System.Drawing.Point(185, 42);
            this.MessageContentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MessageContentLabel.Name = "MessageContentLabel";
            this.MessageContentLabel.Size = new System.Drawing.Size(112, 16);
            this.MessageContentLabel.TabIndex = 5;
            this.MessageContentLabel.Text = "Message Content";
            this.MessageContentLabel.Click += new System.EventHandler(this.MessageContentLabel_Click);
            // 
            // MessageContentTextBox
            // 
            this.MessageContentTextBox.Location = new System.Drawing.Point(189, 75);
            this.MessageContentTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MessageContentTextBox.Multiline = true;
            this.MessageContentTextBox.Name = "MessageContentTextBox";
            this.MessageContentTextBox.Size = new System.Drawing.Size(432, 131);
            this.MessageContentTextBox.TabIndex = 4;
            // 
            // PPriortyGroupBox
            // 
            this.PPriortyGroupBox.Controls.Add(this.HighRadioButton);
            this.PPriortyGroupBox.Controls.Add(this.MediumRadioButton);
            this.PPriortyGroupBox.Controls.Add(this.LowRadioButton);
            this.PPriortyGroupBox.Location = new System.Drawing.Point(20, 42);
            this.PPriortyGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PPriortyGroupBox.Name = "PPriortyGroupBox";
            this.PPriortyGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PPriortyGroupBox.Size = new System.Drawing.Size(140, 126);
            this.PPriortyGroupBox.TabIndex = 0;
            this.PPriortyGroupBox.TabStop = false;
            this.PPriortyGroupBox.Text = "Priority";
            // 
            // HighRadioButton
            // 
            this.HighRadioButton.AutoSize = true;
            this.HighRadioButton.Location = new System.Drawing.Point(21, 91);
            this.HighRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HighRadioButton.Name = "HighRadioButton";
            this.HighRadioButton.Size = new System.Drawing.Size(56, 20);
            this.HighRadioButton.TabIndex = 2;
            this.HighRadioButton.TabStop = true;
            this.HighRadioButton.Text = "High";
            this.HighRadioButton.UseVisualStyleBackColor = true;
            // 
            // MediumRadioButton
            // 
            this.MediumRadioButton.AutoSize = true;
            this.MediumRadioButton.Location = new System.Drawing.Point(21, 63);
            this.MediumRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MediumRadioButton.Name = "MediumRadioButton";
            this.MediumRadioButton.Size = new System.Drawing.Size(76, 20);
            this.MediumRadioButton.TabIndex = 1;
            this.MediumRadioButton.TabStop = true;
            this.MediumRadioButton.Text = "Medium";
            this.MediumRadioButton.UseVisualStyleBackColor = true;
            this.MediumRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // LowRadioButton
            // 
            this.LowRadioButton.AutoSize = true;
            this.LowRadioButton.Location = new System.Drawing.Point(21, 34);
            this.LowRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LowRadioButton.Name = "LowRadioButton";
            this.LowRadioButton.Size = new System.Drawing.Size(52, 20);
            this.LowRadioButton.TabIndex = 0;
            this.LowRadioButton.TabStop = true;
            this.LowRadioButton.Text = "Low";
            this.LowRadioButton.UseVisualStyleBackColor = true;
            // 
            // Producer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 389);
            this.Controls.Add(this.MessageGroupBox);
            this.Controls.Add(this.ServerResponseTextBox);
            this.Controls.Add(this.ServerResponseLabel);
            this.Controls.Add(this.SettingsGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Producer";
            this.Text = "SMPProducer";
            this.SettingsGroupBox.ResumeLayout(false);
            this.SettingsGroupBox.PerformLayout();
            this.MessageGroupBox.ResumeLayout(false);
            this.MessageGroupBox.PerformLayout();
            this.PPriortyGroupBox.ResumeLayout(false);
            this.PPriortyGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SettingsGroupBox;
        private System.Windows.Forms.Label ServerIPAddressLabel;
        private System.Windows.Forms.TextBox ServerIPAddressTextBox;
        private System.Windows.Forms.Label ApplicationPortNumberLabel;
        private System.Windows.Forms.TextBox ApplicationPortNumberTextBox;
        private System.Windows.Forms.Label ServerResponseLabel;
        private System.Windows.Forms.TextBox ServerResponseTextBox;
        private System.Windows.Forms.GroupBox MessageGroupBox;
        private System.Windows.Forms.GroupBox PPriortyGroupBox;
        private System.Windows.Forms.RadioButton HighRadioButton;
        private System.Windows.Forms.RadioButton MediumRadioButton;
        private System.Windows.Forms.RadioButton LowRadioButton;
        private System.Windows.Forms.Button SendMessageButton;
        private System.Windows.Forms.Label MessageContentLabel;
        private System.Windows.Forms.TextBox MessageContentTextBox;
    }
}

