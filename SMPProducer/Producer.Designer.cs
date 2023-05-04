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
            this.SettingsGroupBox.Location = new System.Drawing.Point(18, 18);
            this.SettingsGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SettingsGroupBox.Size = new System.Drawing.Size(765, 82);
            this.SettingsGroupBox.TabIndex = 0;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "Settings";
            // 
            // ApplicationPortNumberTextBox
            // 
            this.ApplicationPortNumberTextBox.Location = new System.Drawing.Point(552, 29);
            this.ApplicationPortNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ApplicationPortNumberTextBox.Name = "ApplicationPortNumberTextBox";
            this.ApplicationPortNumberTextBox.Size = new System.Drawing.Size(122, 26);
            this.ApplicationPortNumberTextBox.TabIndex = 3;
            this.ApplicationPortNumberTextBox.Text = "50444";
            // 
            // ApplicationPortNumberLabel
            // 
            this.ApplicationPortNumberLabel.AutoSize = true;
            this.ApplicationPortNumberLabel.Location = new System.Drawing.Point(362, 38);
            this.ApplicationPortNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ApplicationPortNumberLabel.Name = "ApplicationPortNumberLabel";
            this.ApplicationPortNumberLabel.Size = new System.Drawing.Size(180, 20);
            this.ApplicationPortNumberLabel.TabIndex = 2;
            this.ApplicationPortNumberLabel.Text = "Application Port Number";
            // 
            // ServerIPAddressTextBox
            // 
            this.ServerIPAddressTextBox.Location = new System.Drawing.Point(170, 34);
            this.ServerIPAddressTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ServerIPAddressTextBox.Name = "ServerIPAddressTextBox";
            this.ServerIPAddressTextBox.Size = new System.Drawing.Size(160, 26);
            this.ServerIPAddressTextBox.TabIndex = 1;
            this.ServerIPAddressTextBox.Text = "127.0.0.1";
            // 
            // ServerIPAddressLabel
            // 
            this.ServerIPAddressLabel.AutoSize = true;
            this.ServerIPAddressLabel.Location = new System.Drawing.Point(22, 38);
            this.ServerIPAddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServerIPAddressLabel.Name = "ServerIPAddressLabel";
            this.ServerIPAddressLabel.Size = new System.Drawing.Size(137, 20);
            this.ServerIPAddressLabel.TabIndex = 0;
            this.ServerIPAddressLabel.Text = "Server IP Address";
            // 
            // ServerResponseLabel
            // 
            this.ServerResponseLabel.AutoSize = true;
            this.ServerResponseLabel.Location = new System.Drawing.Point(15, 114);
            this.ServerResponseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServerResponseLabel.Name = "ServerResponseLabel";
            this.ServerResponseLabel.Size = new System.Drawing.Size(132, 20);
            this.ServerResponseLabel.TabIndex = 1;
            this.ServerResponseLabel.Text = "Server Response";
            // 
            // ServerResponseTextBox
            // 
            this.ServerResponseTextBox.Location = new System.Drawing.Point(206, 109);
            this.ServerResponseTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ServerResponseTextBox.Name = "ServerResponseTextBox";
            this.ServerResponseTextBox.Size = new System.Drawing.Size(547, 26);
            this.ServerResponseTextBox.TabIndex = 4;
            // 
            // MessageGroupBox
            // 
            this.MessageGroupBox.Controls.Add(this.SendMessageButton);
            this.MessageGroupBox.Controls.Add(this.MessageContentLabel);
            this.MessageGroupBox.Controls.Add(this.MessageContentTextBox);
            this.MessageGroupBox.Controls.Add(this.PPriortyGroupBox);
            this.MessageGroupBox.Location = new System.Drawing.Point(22, 149);
            this.MessageGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MessageGroupBox.Name = "MessageGroupBox";
            this.MessageGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MessageGroupBox.Size = new System.Drawing.Size(760, 323);
            this.MessageGroupBox.TabIndex = 5;
            this.MessageGroupBox.TabStop = false;
            this.MessageGroupBox.Text = "Message";
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.Location = new System.Drawing.Point(214, 266);
            this.SendMessageButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(518, 38);
            this.SendMessageButton.TabIndex = 6;
            this.SendMessageButton.Text = "Send Message";
            this.SendMessageButton.UseVisualStyleBackColor = true;
            this.SendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // MessageContentLabel
            // 
            this.MessageContentLabel.AutoSize = true;
            this.MessageContentLabel.Location = new System.Drawing.Point(208, 52);
            this.MessageContentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MessageContentLabel.Name = "MessageContentLabel";
            this.MessageContentLabel.Size = new System.Drawing.Size(135, 20);
            this.MessageContentLabel.TabIndex = 5;
            this.MessageContentLabel.Text = "Message Content";
            // 
            // MessageContentTextBox
            // 
            this.MessageContentTextBox.Location = new System.Drawing.Point(213, 94);
            this.MessageContentTextBox.Multiline = true;
            this.MessageContentTextBox.Name = "MessageContentTextBox";
            this.MessageContentTextBox.Size = new System.Drawing.Size(517, 162);
            this.MessageContentTextBox.TabIndex = 4;
            // 
            // PPriortyGroupBox
            // 
            this.PPriortyGroupBox.Controls.Add(this.HighRadioButton);
            this.PPriortyGroupBox.Controls.Add(this.MediumRadioButton);
            this.PPriortyGroupBox.Controls.Add(this.LowRadioButton);
            this.PPriortyGroupBox.Location = new System.Drawing.Point(22, 52);
            this.PPriortyGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PPriortyGroupBox.Name = "PPriortyGroupBox";
            this.PPriortyGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PPriortyGroupBox.Size = new System.Drawing.Size(158, 157);
            this.PPriortyGroupBox.TabIndex = 0;
            this.PPriortyGroupBox.TabStop = false;
            this.PPriortyGroupBox.Text = "Priority";
            // 
            // HighRadioButton
            // 
            this.HighRadioButton.AutoSize = true;
            this.HighRadioButton.Location = new System.Drawing.Point(24, 114);
            this.HighRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HighRadioButton.Name = "HighRadioButton";
            this.HighRadioButton.Size = new System.Drawing.Size(67, 24);
            this.HighRadioButton.TabIndex = 2;
            this.HighRadioButton.Text = "High";
            this.HighRadioButton.UseVisualStyleBackColor = true;
            // 
            // MediumRadioButton
            // 
            this.MediumRadioButton.AutoSize = true;
            this.MediumRadioButton.Location = new System.Drawing.Point(24, 78);
            this.MediumRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MediumRadioButton.Name = "MediumRadioButton";
            this.MediumRadioButton.Size = new System.Drawing.Size(90, 24);
            this.MediumRadioButton.TabIndex = 1;
            this.MediumRadioButton.Text = "Medium";
            this.MediumRadioButton.UseVisualStyleBackColor = true;
            // 
            // LowRadioButton
            // 
            this.LowRadioButton.AutoSize = true;
            this.LowRadioButton.Checked = true;
            this.LowRadioButton.Location = new System.Drawing.Point(24, 43);
            this.LowRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LowRadioButton.Name = "LowRadioButton";
            this.LowRadioButton.Size = new System.Drawing.Size(63, 24);
            this.LowRadioButton.TabIndex = 0;
            this.LowRadioButton.TabStop = true;
            this.LowRadioButton.Text = "Low";
            this.LowRadioButton.UseVisualStyleBackColor = true;
            // 
            // ProducerStatusBar
            // 
            this.ProducerStatusBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProducerStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProducerStatusBar.Location = new System.Drawing.Point(0, 492);
            this.ProducerStatusBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProducerStatusBar.Name = "ProducerStatusBar";
            this.ProducerStatusBar.ReadOnly = true;
            this.ProducerStatusBar.Size = new System.Drawing.Size(801, 26);
            this.ProducerStatusBar.TabIndex = 6;
            // 
            // Producer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 518);
            this.Controls.Add(this.ProducerStatusBar);
            this.Controls.Add(this.MessageGroupBox);
            this.Controls.Add(this.ServerResponseTextBox);
            this.Controls.Add(this.ServerResponseLabel);
            this.Controls.Add(this.SettingsGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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

