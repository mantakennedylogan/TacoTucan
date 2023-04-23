namespace SMPConsumer
{
    partial class ConsumerGUI
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
            this.ServerIPAdressLabel = new System.Windows.Forms.Label();
            this.MessageGroupBox = new System.Windows.Forms.GroupBox();
            this.GetMessageButton = new System.Windows.Forms.Button();
            this.MessageContentTextBox = new System.Windows.Forms.TextBox();
            this.MessageContentLabel = new System.Windows.Forms.Label();
            this.PriorityGroupBox = new System.Windows.Forms.GroupBox();
            this.HighRadioButton = new System.Windows.Forms.RadioButton();
            this.MediumRadioButton = new System.Windows.Forms.RadioButton();
            this.LowRadioButton = new System.Windows.Forms.RadioButton();
            this.SettingsGroupBox.SuspendLayout();
            this.MessageGroupBox.SuspendLayout();
            this.PriorityGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsGroupBox
            // 
            this.SettingsGroupBox.Controls.Add(this.ApplicationPortNumberTextBox);
            this.SettingsGroupBox.Controls.Add(this.ApplicationPortNumberLabel);
            this.SettingsGroupBox.Controls.Add(this.ServerIPAddressTextBox);
            this.SettingsGroupBox.Controls.Add(this.ServerIPAdressLabel);
            this.SettingsGroupBox.Location = new System.Drawing.Point(17, 15);
            this.SettingsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.SettingsGroupBox.Size = new System.Drawing.Size(679, 80);
            this.SettingsGroupBox.TabIndex = 0;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "Settings";
            // 
            // ApplicationPortNumberTextBox
            // 
            this.ApplicationPortNumberTextBox.Location = new System.Drawing.Point(525, 30);
            this.ApplicationPortNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ApplicationPortNumberTextBox.Name = "ApplicationPortNumberTextBox";
            this.ApplicationPortNumberTextBox.Size = new System.Drawing.Size(144, 22);
            this.ApplicationPortNumberTextBox.TabIndex = 3;
            this.ApplicationPortNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ApplicationPortNumberLabel
            // 
            this.ApplicationPortNumberLabel.AutoSize = true;
            this.ApplicationPortNumberLabel.Location = new System.Drawing.Point(356, 33);
            this.ApplicationPortNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ApplicationPortNumberLabel.Name = "ApplicationPortNumberLabel";
            this.ApplicationPortNumberLabel.Size = new System.Drawing.Size(152, 16);
            this.ApplicationPortNumberLabel.TabIndex = 2;
            this.ApplicationPortNumberLabel.Text = "Application Port Number";
            // 
            // ServerIPAddressTextBox
            // 
            this.ServerIPAddressTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ServerIPAddressTextBox.Location = new System.Drawing.Point(139, 30);
            this.ServerIPAddressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ServerIPAddressTextBox.Name = "ServerIPAddressTextBox";
            this.ServerIPAddressTextBox.Size = new System.Drawing.Size(208, 22);
            this.ServerIPAddressTextBox.TabIndex = 1;
            this.ServerIPAddressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ServerIPAdressLabel
            // 
            this.ServerIPAdressLabel.AutoSize = true;
            this.ServerIPAdressLabel.Location = new System.Drawing.Point(8, 33);
            this.ServerIPAdressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServerIPAdressLabel.Name = "ServerIPAdressLabel";
            this.ServerIPAdressLabel.Size = new System.Drawing.Size(116, 16);
            this.ServerIPAdressLabel.TabIndex = 0;
            this.ServerIPAdressLabel.Text = "Server IP Address";
            this.ServerIPAdressLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // MessageGroupBox
            // 
            this.MessageGroupBox.Controls.Add(this.GetMessageButton);
            this.MessageGroupBox.Controls.Add(this.MessageContentTextBox);
            this.MessageGroupBox.Controls.Add(this.MessageContentLabel);
            this.MessageGroupBox.Controls.Add(this.PriorityGroupBox);
            this.MessageGroupBox.Location = new System.Drawing.Point(16, 102);
            this.MessageGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.MessageGroupBox.Name = "MessageGroupBox";
            this.MessageGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.MessageGroupBox.Size = new System.Drawing.Size(680, 272);
            this.MessageGroupBox.TabIndex = 1;
            this.MessageGroupBox.TabStop = false;
            this.MessageGroupBox.Text = "Message";
            // 
            // GetMessageButton
            // 
            this.GetMessageButton.Location = new System.Drawing.Point(168, 228);
            this.GetMessageButton.Margin = new System.Windows.Forms.Padding(4);
            this.GetMessageButton.Name = "GetMessageButton";
            this.GetMessageButton.Size = new System.Drawing.Size(492, 37);
            this.GetMessageButton.TabIndex = 3;
            this.GetMessageButton.Text = "Get Message";
            this.GetMessageButton.UseVisualStyleBackColor = true;
            this.GetMessageButton.Click += new System.EventHandler(this.GetMessageButton_Click_1);
            // 
            // MessageContentTextBox
            // 
            this.MessageContentTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MessageContentTextBox.Location = new System.Drawing.Point(168, 44);
            this.MessageContentTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 16, 4);
            this.MessageContentTextBox.Multiline = true;
            this.MessageContentTextBox.Name = "MessageContentTextBox";
            this.MessageContentTextBox.ReadOnly = true;
            this.MessageContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MessageContentTextBox.Size = new System.Drawing.Size(491, 175);
            this.MessageContentTextBox.TabIndex = 2;
            // 
            // MessageContentLabel
            // 
            this.MessageContentLabel.AutoSize = true;
            this.MessageContentLabel.Location = new System.Drawing.Point(164, 23);
            this.MessageContentLabel.Margin = new System.Windows.Forms.Padding(16, 0, 4, 0);
            this.MessageContentLabel.Name = "MessageContentLabel";
            this.MessageContentLabel.Size = new System.Drawing.Size(112, 16);
            this.MessageContentLabel.TabIndex = 1;
            this.MessageContentLabel.Text = "Message Content";
            // 
            // PriorityGroupBox
            // 
            this.PriorityGroupBox.Controls.Add(this.HighRadioButton);
            this.PriorityGroupBox.Controls.Add(this.MediumRadioButton);
            this.PriorityGroupBox.Controls.Add(this.LowRadioButton);
            this.PriorityGroupBox.Location = new System.Drawing.Point(20, 23);
            this.PriorityGroupBox.Margin = new System.Windows.Forms.Padding(16, 4, 4, 4);
            this.PriorityGroupBox.Name = "PriorityGroupBox";
            this.PriorityGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.PriorityGroupBox.Size = new System.Drawing.Size(124, 241);
            this.PriorityGroupBox.TabIndex = 0;
            this.PriorityGroupBox.TabStop = false;
            this.PriorityGroupBox.Text = "Priority";
            this.PriorityGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // HighRadioButton
            // 
            this.HighRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.HighRadioButton.AutoSize = true;
            this.HighRadioButton.Location = new System.Drawing.Point(12, 176);
            this.HighRadioButton.Margin = new System.Windows.Forms.Padding(8, 15, 8, 25);
            this.HighRadioButton.Name = "HighRadioButton";
            this.HighRadioButton.Size = new System.Drawing.Size(56, 20);
            this.HighRadioButton.TabIndex = 2;
            this.HighRadioButton.Text = "High";
            this.HighRadioButton.UseVisualStyleBackColor = true;
            // 
            // MediumRadioButton
            // 
            this.MediumRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MediumRadioButton.AutoSize = true;
            this.MediumRadioButton.Location = new System.Drawing.Point(12, 116);
            this.MediumRadioButton.Margin = new System.Windows.Forms.Padding(8, 15, 8, 15);
            this.MediumRadioButton.Name = "MediumRadioButton";
            this.MediumRadioButton.Size = new System.Drawing.Size(76, 20);
            this.MediumRadioButton.TabIndex = 1;
            this.MediumRadioButton.Text = "Medium";
            this.MediumRadioButton.UseVisualStyleBackColor = true;
            // 
            // LowRadioButton
            // 
            this.LowRadioButton.AutoSize = true;
            this.LowRadioButton.Location = new System.Drawing.Point(12, 53);
            this.LowRadioButton.Margin = new System.Windows.Forms.Padding(8, 25, 8, 15);
            this.LowRadioButton.Name = "LowRadioButton";
            this.LowRadioButton.Size = new System.Drawing.Size(52, 20);
            this.LowRadioButton.TabIndex = 0;
            this.LowRadioButton.Text = "Low";
            this.LowRadioButton.UseVisualStyleBackColor = true;
            // 
            // ConsumerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 389);
            this.Controls.Add(this.MessageGroupBox);
            this.Controls.Add(this.SettingsGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsumerGUI";
            this.Text = "SMP Client Consumer Version 1.0";
            this.SettingsGroupBox.ResumeLayout(false);
            this.SettingsGroupBox.PerformLayout();
            this.MessageGroupBox.ResumeLayout(false);
            this.MessageGroupBox.PerformLayout();
            this.PriorityGroupBox.ResumeLayout(false);
            this.PriorityGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SettingsGroupBox;
        private System.Windows.Forms.Label ServerIPAdressLabel;
        private System.Windows.Forms.TextBox ApplicationPortNumberTextBox;
        private System.Windows.Forms.Label ApplicationPortNumberLabel;
        private System.Windows.Forms.TextBox ServerIPAddressTextBox;
        private System.Windows.Forms.GroupBox MessageGroupBox;
        private System.Windows.Forms.GroupBox PriorityGroupBox;
        private System.Windows.Forms.Button GetMessageButton;
        private System.Windows.Forms.TextBox MessageContentTextBox;
        private System.Windows.Forms.Label MessageContentLabel;
        private System.Windows.Forms.RadioButton HighRadioButton;
        private System.Windows.Forms.RadioButton MediumRadioButton;
        private System.Windows.Forms.RadioButton LowRadioButton;
    }
}

