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
            this.ProducerStatusBar = new System.Windows.Forms.TextBox();
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
            this.SettingsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Size = new System.Drawing.Size(510, 53);
            this.SettingsGroupBox.TabIndex = 0;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "Settings";
            // 
            // ApplicationPortNumberTextBox
            // 
            this.ApplicationPortNumberTextBox.Location = new System.Drawing.Point(368, 19);
            this.ApplicationPortNumberTextBox.Name = "ApplicationPortNumberTextBox";
            this.ApplicationPortNumberTextBox.Size = new System.Drawing.Size(83, 20);
            this.ApplicationPortNumberTextBox.TabIndex = 3;
            // 
            // ApplicationPortNumberLabel
            // 
            this.ApplicationPortNumberLabel.AutoSize = true;
            this.ApplicationPortNumberLabel.Location = new System.Drawing.Point(241, 25);
            this.ApplicationPortNumberLabel.Name = "ApplicationPortNumberLabel";
            this.ApplicationPortNumberLabel.Size = new System.Drawing.Size(121, 13);
            this.ApplicationPortNumberLabel.TabIndex = 2;
            this.ApplicationPortNumberLabel.Text = "Application Port Number";
            // 
            // ServerIPAddressTextBox
            // 
            this.ServerIPAddressTextBox.Location = new System.Drawing.Point(113, 22);
            this.ServerIPAddressTextBox.Name = "ServerIPAddressTextBox";
            this.ServerIPAddressTextBox.Size = new System.Drawing.Size(108, 20);
            this.ServerIPAddressTextBox.TabIndex = 1;
            // 
            // ServerIPAddressLabel
            // 
            this.ServerIPAddressLabel.AutoSize = true;
            this.ServerIPAddressLabel.Location = new System.Drawing.Point(15, 25);
            this.ServerIPAddressLabel.Name = "ServerIPAddressLabel";
            this.ServerIPAddressLabel.Size = new System.Drawing.Size(92, 13);
            this.ServerIPAddressLabel.TabIndex = 0;
            this.ServerIPAddressLabel.Text = "Server IP Address";
            // 
            // ServerResponseLabel
            // 
            this.ServerResponseLabel.AutoSize = true;
            this.ServerResponseLabel.Location = new System.Drawing.Point(10, 74);
            this.ServerResponseLabel.Name = "ServerResponseLabel";
            this.ServerResponseLabel.Size = new System.Drawing.Size(89, 13);
            this.ServerResponseLabel.TabIndex = 1;
            this.ServerResponseLabel.Text = "Server Response";
            // 
            // ServerResponseTextBox
            // 
            this.ServerResponseTextBox.Location = new System.Drawing.Point(137, 71);
            this.ServerResponseTextBox.Name = "ServerResponseTextBox";
            this.ServerResponseTextBox.Size = new System.Drawing.Size(366, 20);
            this.ServerResponseTextBox.TabIndex = 4;
            // 
            // MessageGroupBox
            // 
            this.MessageGroupBox.Controls.Add(this.SendMessageButton);
            this.MessageGroupBox.Controls.Add(this.MessageContentLabel);
            this.MessageGroupBox.Controls.Add(this.MessageContentTextBox);
            this.MessageGroupBox.Controls.Add(this.PPriortyGroupBox);
            this.MessageGroupBox.Location = new System.Drawing.Point(15, 97);
            this.MessageGroupBox.Name = "MessageGroupBox";
            this.MessageGroupBox.Size = new System.Drawing.Size(507, 210);
            this.MessageGroupBox.TabIndex = 5;
            this.MessageGroupBox.TabStop = false;
            this.MessageGroupBox.Text = "Message";
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.Location = new System.Drawing.Point(143, 173);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(345, 25);
            this.SendMessageButton.TabIndex = 6;
            this.SendMessageButton.Text = "Send Message";
            this.SendMessageButton.UseVisualStyleBackColor = true;
            this.SendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // MessageContentLabel
            // 
            this.MessageContentLabel.AutoSize = true;
            this.MessageContentLabel.Location = new System.Drawing.Point(139, 34);
            this.MessageContentLabel.Name = "MessageContentLabel";
            this.MessageContentLabel.Size = new System.Drawing.Size(90, 13);
            this.MessageContentLabel.TabIndex = 5;
            this.MessageContentLabel.Text = "Message Content";
            // 
            // MessageContentTextBox
            // 
            this.MessageContentTextBox.Location = new System.Drawing.Point(142, 61);
            this.MessageContentTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MessageContentTextBox.Multiline = true;
            this.MessageContentTextBox.Name = "MessageContentTextBox";
            this.MessageContentTextBox.Size = new System.Drawing.Size(346, 107);
            this.MessageContentTextBox.TabIndex = 4;
            // 
            // PPriortyGroupBox
            // 
            this.PPriortyGroupBox.Controls.Add(this.HighRadioButton);
            this.PPriortyGroupBox.Controls.Add(this.MediumRadioButton);
            this.PPriortyGroupBox.Controls.Add(this.LowRadioButton);
            this.PPriortyGroupBox.Location = new System.Drawing.Point(15, 34);
            this.PPriortyGroupBox.Name = "PPriortyGroupBox";
            this.PPriortyGroupBox.Size = new System.Drawing.Size(105, 102);
            this.PPriortyGroupBox.TabIndex = 0;
            this.PPriortyGroupBox.TabStop = false;
            this.PPriortyGroupBox.Text = "Priority";
            // 
            // HighRadioButton
            // 
            this.HighRadioButton.AutoSize = true;
            this.HighRadioButton.Location = new System.Drawing.Point(16, 74);
            this.HighRadioButton.Name = "HighRadioButton";
            this.HighRadioButton.Size = new System.Drawing.Size(47, 17);
            this.HighRadioButton.TabIndex = 2;
            this.HighRadioButton.Text = "High";
            this.HighRadioButton.UseVisualStyleBackColor = true;
            // 
            // MediumRadioButton
            // 
            this.MediumRadioButton.AutoSize = true;
            this.MediumRadioButton.Location = new System.Drawing.Point(16, 51);
            this.MediumRadioButton.Name = "MediumRadioButton";
            this.MediumRadioButton.Size = new System.Drawing.Size(62, 17);
            this.MediumRadioButton.TabIndex = 1;
            this.MediumRadioButton.Text = "Medium";
            this.MediumRadioButton.UseVisualStyleBackColor = true;
            // 
            // LowRadioButton
            // 
            this.LowRadioButton.AutoSize = true;
            this.LowRadioButton.Checked = true;
            this.LowRadioButton.Location = new System.Drawing.Point(16, 28);
            this.LowRadioButton.Name = "LowRadioButton";
            this.LowRadioButton.Size = new System.Drawing.Size(45, 17);
            this.LowRadioButton.TabIndex = 0;
            this.LowRadioButton.TabStop = true;
            this.LowRadioButton.Text = "Low";
            this.LowRadioButton.UseVisualStyleBackColor = true;
            // 
            // ProducerStatusBar
            // 
            this.ProducerStatusBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProducerStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProducerStatusBar.Location = new System.Drawing.Point(0, 317);
            this.ProducerStatusBar.Name = "ProducerStatusBar";
            this.ProducerStatusBar.ReadOnly = true;
            this.ProducerStatusBar.Size = new System.Drawing.Size(534, 20);
            this.ProducerStatusBar.TabIndex = 6;
            // 
            // Producer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 337);
            this.Controls.Add(this.ProducerStatusBar);
            this.Controls.Add(this.MessageGroupBox);
            this.Controls.Add(this.ServerResponseTextBox);
            this.Controls.Add(this.ServerResponseLabel);
            this.Controls.Add(this.SettingsGroupBox);
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
        private System.Windows.Forms.TextBox ProducerStatusBar;
    }
}

