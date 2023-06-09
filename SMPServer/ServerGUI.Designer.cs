﻿namespace Server
{
    partial class ServerGUI
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
            this.StartServerButton = new System.Windows.Forms.Button();
            this.SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.ServerIPLabel = new System.Windows.Forms.Label();
            this.PortNumberTextBox = new System.Windows.Forms.TextBox();
            this.ServerIPAddressTextBox = new System.Windows.Forms.TextBox();
            this.LastReceivedMessageGroupBox = new System.Windows.Forms.GroupBox();
            this.MessageTypeTextBox = new System.Windows.Forms.TextBox();
            this.MessagePriorityTextbox = new System.Windows.Forms.TextBox();
            this.MessagePriorityLabel = new System.Windows.Forms.Label();
            this.MessageTypeLabel = new System.Windows.Forms.Label();
            this.MessagesGroupBox = new System.Windows.Forms.GroupBox();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.ShowMessagesButton = new System.Windows.Forms.Button();
            this.PriorityGroupBox = new System.Windows.Forms.GroupBox();
            this.AllPriorityRadioButton = new System.Windows.Forms.RadioButton();
            this.MediumPriorityadioButton = new System.Windows.Forms.RadioButton();
            this.HighPriorityRadioButton = new System.Windows.Forms.RadioButton();
            this.LowPriorityRadioButton = new System.Windows.Forms.RadioButton();
            this.ServerStatusTextBox = new System.Windows.Forms.TextBox();
            this.SettingsGroupBox.SuspendLayout();
            this.LastReceivedMessageGroupBox.SuspendLayout();
            this.MessagesGroupBox.SuspendLayout();
            this.PriorityGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartServerButton
            // 
            this.StartServerButton.Location = new System.Drawing.Point(25, 18);
            this.StartServerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartServerButton.Name = "StartServerButton";
            this.StartServerButton.Size = new System.Drawing.Size(165, 136);
            this.StartServerButton.TabIndex = 0;
            this.StartServerButton.Text = "Start Server";
            this.StartServerButton.UseVisualStyleBackColor = true;
            this.StartServerButton.Click += new System.EventHandler(this.StartServerButton_Click);
            // 
            // SettingsGroupBox
            // 
            this.SettingsGroupBox.Controls.Add(this.PortLabel);
            this.SettingsGroupBox.Controls.Add(this.ServerIPLabel);
            this.SettingsGroupBox.Controls.Add(this.PortNumberTextBox);
            this.SettingsGroupBox.Controls.Add(this.ServerIPAddressTextBox);
            this.SettingsGroupBox.Location = new System.Drawing.Point(208, 18);
            this.SettingsGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SettingsGroupBox.Size = new System.Drawing.Size(450, 136);
            this.SettingsGroupBox.TabIndex = 1;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "Settings";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(11, 86);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(98, 20);
            this.PortLabel.TabIndex = 3;
            this.PortLabel.Text = "Port Number";
            // 
            // ServerIPLabel
            // 
            this.ServerIPLabel.AutoSize = true;
            this.ServerIPLabel.Location = new System.Drawing.Point(11, 38);
            this.ServerIPLabel.Name = "ServerIPLabel";
            this.ServerIPLabel.Size = new System.Drawing.Size(137, 20);
            this.ServerIPLabel.TabIndex = 2;
            this.ServerIPLabel.Text = "Server IP Address";
            // 
            // PortNumberTextBox
            // 
            this.PortNumberTextBox.Location = new System.Drawing.Point(154, 86);
            this.PortNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PortNumberTextBox.Name = "PortNumberTextBox";
            this.PortNumberTextBox.Size = new System.Drawing.Size(271, 26);
            this.PortNumberTextBox.TabIndex = 1;
            this.PortNumberTextBox.Text = "50444";
            this.PortNumberTextBox.TextChanged += new System.EventHandler(this.PortNumberTextBox_TextChanged);
            // 
            // ServerIPAddressTextBox
            // 
            this.ServerIPAddressTextBox.Location = new System.Drawing.Point(154, 32);
            this.ServerIPAddressTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ServerIPAddressTextBox.Name = "ServerIPAddressTextBox";
            this.ServerIPAddressTextBox.Size = new System.Drawing.Size(271, 26);
            this.ServerIPAddressTextBox.TabIndex = 0;
            this.ServerIPAddressTextBox.Text = "0.0.0.0";
            // 
            // LastReceivedMessageGroupBox
            // 
            this.LastReceivedMessageGroupBox.Controls.Add(this.MessageTypeTextBox);
            this.LastReceivedMessageGroupBox.Controls.Add(this.MessagePriorityTextbox);
            this.LastReceivedMessageGroupBox.Controls.Add(this.MessagePriorityLabel);
            this.LastReceivedMessageGroupBox.Controls.Add(this.MessageTypeLabel);
            this.LastReceivedMessageGroupBox.Location = new System.Drawing.Point(28, 169);
            this.LastReceivedMessageGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LastReceivedMessageGroupBox.Name = "LastReceivedMessageGroupBox";
            this.LastReceivedMessageGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LastReceivedMessageGroupBox.Size = new System.Drawing.Size(630, 88);
            this.LastReceivedMessageGroupBox.TabIndex = 2;
            this.LastReceivedMessageGroupBox.TabStop = false;
            this.LastReceivedMessageGroupBox.Text = "Last Received Message";
            // 
            // MessageTypeTextBox
            // 
            this.MessageTypeTextBox.Location = new System.Drawing.Point(125, 40);
            this.MessageTypeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MessageTypeTextBox.Name = "MessageTypeTextBox";
            this.MessageTypeTextBox.Size = new System.Drawing.Size(152, 26);
            this.MessageTypeTextBox.TabIndex = 6;
            // 
            // MessagePriorityTextbox
            // 
            this.MessagePriorityTextbox.Location = new System.Drawing.Point(424, 40);
            this.MessagePriorityTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MessagePriorityTextbox.Name = "MessagePriorityTextbox";
            this.MessagePriorityTextbox.Size = new System.Drawing.Size(180, 26);
            this.MessagePriorityTextbox.TabIndex = 5;
            // 
            // MessagePriorityLabel
            // 
            this.MessagePriorityLabel.AutoSize = true;
            this.MessagePriorityLabel.Location = new System.Drawing.Point(297, 42);
            this.MessagePriorityLabel.Name = "MessagePriorityLabel";
            this.MessagePriorityLabel.Size = new System.Drawing.Size(125, 20);
            this.MessagePriorityLabel.TabIndex = 1;
            this.MessagePriorityLabel.Text = "Message Priority";
            // 
            // MessageTypeLabel
            // 
            this.MessageTypeLabel.AutoSize = true;
            this.MessageTypeLabel.Location = new System.Drawing.Point(8, 40);
            this.MessageTypeLabel.Name = "MessageTypeLabel";
            this.MessageTypeLabel.Size = new System.Drawing.Size(112, 20);
            this.MessageTypeLabel.TabIndex = 0;
            this.MessageTypeLabel.Text = "Message Type";
            // 
            // MessagesGroupBox
            // 
            this.MessagesGroupBox.Controls.Add(this.MessageTextBox);
            this.MessagesGroupBox.Controls.Add(this.ShowMessagesButton);
            this.MessagesGroupBox.Controls.Add(this.PriorityGroupBox);
            this.MessagesGroupBox.Location = new System.Drawing.Point(37, 279);
            this.MessagesGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MessagesGroupBox.Name = "MessagesGroupBox";
            this.MessagesGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MessagesGroupBox.Size = new System.Drawing.Size(622, 301);
            this.MessagesGroupBox.TabIndex = 3;
            this.MessagesGroupBox.TabStop = false;
            this.MessagesGroupBox.Text = "Messages";
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MessageTextBox.Location = new System.Drawing.Point(168, 34);
            this.MessageTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.ReadOnly = true;
            this.MessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MessageTextBox.Size = new System.Drawing.Size(428, 192);
            this.MessageTextBox.TabIndex = 3;
            // 
            // ShowMessagesButton
            // 
            this.ShowMessagesButton.Location = new System.Drawing.Point(269, 241);
            this.ShowMessagesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowMessagesButton.Name = "ShowMessagesButton";
            this.ShowMessagesButton.Size = new System.Drawing.Size(230, 39);
            this.ShowMessagesButton.TabIndex = 2;
            this.ShowMessagesButton.Text = "Show Messages";
            this.ShowMessagesButton.UseVisualStyleBackColor = true;
            this.ShowMessagesButton.Click += new System.EventHandler(this.ShowMessagesButton_Click);
            // 
            // PriorityGroupBox
            // 
            this.PriorityGroupBox.Controls.Add(this.AllPriorityRadioButton);
            this.PriorityGroupBox.Controls.Add(this.MediumPriorityadioButton);
            this.PriorityGroupBox.Controls.Add(this.HighPriorityRadioButton);
            this.PriorityGroupBox.Controls.Add(this.LowPriorityRadioButton);
            this.PriorityGroupBox.Location = new System.Drawing.Point(6, 25);
            this.PriorityGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PriorityGroupBox.Name = "PriorityGroupBox";
            this.PriorityGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PriorityGroupBox.Size = new System.Drawing.Size(141, 219);
            this.PriorityGroupBox.TabIndex = 0;
            this.PriorityGroupBox.TabStop = false;
            this.PriorityGroupBox.Text = "Priority";
            // 
            // AllPriorityRadioButton
            // 
            this.AllPriorityRadioButton.AutoSize = true;
            this.AllPriorityRadioButton.Checked = true;
            this.AllPriorityRadioButton.Location = new System.Drawing.Point(10, 178);
            this.AllPriorityRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AllPriorityRadioButton.Name = "AllPriorityRadioButton";
            this.AllPriorityRadioButton.Size = new System.Drawing.Size(51, 24);
            this.AllPriorityRadioButton.TabIndex = 3;
            this.AllPriorityRadioButton.TabStop = true;
            this.AllPriorityRadioButton.Text = "All";
            this.AllPriorityRadioButton.UseVisualStyleBackColor = true;
            // 
            // MediumPriorityadioButton
            // 
            this.MediumPriorityadioButton.AutoSize = true;
            this.MediumPriorityadioButton.Location = new System.Drawing.Point(10, 81);
            this.MediumPriorityadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MediumPriorityadioButton.Name = "MediumPriorityadioButton";
            this.MediumPriorityadioButton.Size = new System.Drawing.Size(90, 24);
            this.MediumPriorityadioButton.TabIndex = 2;
            this.MediumPriorityadioButton.Text = "Medium";
            this.MediumPriorityadioButton.UseVisualStyleBackColor = true;
            // 
            // HighPriorityRadioButton
            // 
            this.HighPriorityRadioButton.AutoSize = true;
            this.HighPriorityRadioButton.Location = new System.Drawing.Point(10, 129);
            this.HighPriorityRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HighPriorityRadioButton.Name = "HighPriorityRadioButton";
            this.HighPriorityRadioButton.Size = new System.Drawing.Size(67, 24);
            this.HighPriorityRadioButton.TabIndex = 1;
            this.HighPriorityRadioButton.Text = "High";
            this.HighPriorityRadioButton.UseVisualStyleBackColor = true;
            // 
            // LowPriorityRadioButton
            // 
            this.LowPriorityRadioButton.AutoSize = true;
            this.LowPriorityRadioButton.Location = new System.Drawing.Point(10, 35);
            this.LowPriorityRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LowPriorityRadioButton.Name = "LowPriorityRadioButton";
            this.LowPriorityRadioButton.Size = new System.Drawing.Size(63, 24);
            this.LowPriorityRadioButton.TabIndex = 0;
            this.LowPriorityRadioButton.Text = "Low";
            this.LowPriorityRadioButton.UseVisualStyleBackColor = true;
            // 
            // ServerStatusTextBox
            // 
            this.ServerStatusTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ServerStatusTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ServerStatusTextBox.Location = new System.Drawing.Point(0, 593);
            this.ServerStatusTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ServerStatusTextBox.Name = "ServerStatusTextBox";
            this.ServerStatusTextBox.ReadOnly = true;
            this.ServerStatusTextBox.Size = new System.Drawing.Size(688, 26);
            this.ServerStatusTextBox.TabIndex = 4;
            // 
            // ServerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 619);
            this.Controls.Add(this.ServerStatusTextBox);
            this.Controls.Add(this.MessagesGroupBox);
            this.Controls.Add(this.LastReceivedMessageGroupBox);
            this.Controls.Add(this.SettingsGroupBox);
            this.Controls.Add(this.StartServerButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ServerGUI";
            this.Text = "SMP Server Version 1.0";
            this.SettingsGroupBox.ResumeLayout(false);
            this.SettingsGroupBox.PerformLayout();
            this.LastReceivedMessageGroupBox.ResumeLayout(false);
            this.LastReceivedMessageGroupBox.PerformLayout();
            this.MessagesGroupBox.ResumeLayout(false);
            this.MessagesGroupBox.PerformLayout();
            this.PriorityGroupBox.ResumeLayout(false);
            this.PriorityGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartServerButton;
        private System.Windows.Forms.GroupBox SettingsGroupBox;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.Label ServerIPLabel;
        private System.Windows.Forms.TextBox PortNumberTextBox;
        private System.Windows.Forms.TextBox ServerIPAddressTextBox;
        private System.Windows.Forms.GroupBox LastReceivedMessageGroupBox;
        private System.Windows.Forms.Label MessagePriorityLabel;
        private System.Windows.Forms.Label MessageTypeLabel;
        private System.Windows.Forms.TextBox MessagePriorityTextbox;
        private System.Windows.Forms.TextBox MessageTypeTextBox;
        private System.Windows.Forms.GroupBox MessagesGroupBox;
        private System.Windows.Forms.GroupBox PriorityGroupBox;
        private System.Windows.Forms.RadioButton AllPriorityRadioButton;
        private System.Windows.Forms.RadioButton MediumPriorityadioButton;
        private System.Windows.Forms.RadioButton HighPriorityRadioButton;
        private System.Windows.Forms.RadioButton LowPriorityRadioButton;
        private System.Windows.Forms.Button ShowMessagesButton;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.TextBox ServerStatusTextBox;
    }
}

