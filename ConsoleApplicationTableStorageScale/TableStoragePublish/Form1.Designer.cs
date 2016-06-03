namespace TableStoragePublish
{
    partial class Form1
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
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.locationComboBox = new System.Windows.Forms.ComboBox();
            this.btnSendMessages = new System.Windows.Forms.Button();
            this.nudMessagesSent = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblResultTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMessagesSent)).BeginInit();
            this.SuspendLayout();
            // 
            // stateComboBox
            // 
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Items.AddRange(new object[] {
            "California",
            "Arizona",
            "Utah"});
            this.stateComboBox.Location = new System.Drawing.Point(13, 48);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(121, 21);
            this.stateComboBox.TabIndex = 0;
            this.stateComboBox.Text = "Choose a State";
            this.stateComboBox.SelectedValueChanged += new System.EventHandler(this.stateComboBox_SelectedValueChanged);
            // 
            // locationComboBox
            // 
            this.locationComboBox.FormattingEnabled = true;
            this.locationComboBox.Location = new System.Drawing.Point(163, 48);
            this.locationComboBox.Name = "locationComboBox";
            this.locationComboBox.Size = new System.Drawing.Size(121, 21);
            this.locationComboBox.TabIndex = 1;
            this.locationComboBox.Text = "Choose Location";
            // 
            // btnSendMessages
            // 
            this.btnSendMessages.Location = new System.Drawing.Point(209, 105);
            this.btnSendMessages.Name = "btnSendMessages";
            this.btnSendMessages.Size = new System.Drawing.Size(75, 23);
            this.btnSendMessages.TabIndex = 2;
            this.btnSendMessages.Text = "Send Messages";
            this.btnSendMessages.UseVisualStyleBackColor = true;
            this.btnSendMessages.Click += new System.EventHandler(this.btnSendMessages_Click);
            // 
            // nudMessagesSent
            // 
            this.nudMessagesSent.Location = new System.Drawing.Point(14, 108);
            this.nudMessagesSent.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMessagesSent.Name = "nudMessagesSent";
            this.nudMessagesSent.Size = new System.Drawing.Size(120, 20);
            this.nudMessagesSent.TabIndex = 3;
            this.nudMessagesSent.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Messages Sent:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(98, 143);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(13, 13);
            this.lblCount.TabIndex = 5;
            this.lblCount.Text = "0";
            // 
            // lblResultTime
            // 
            this.lblResultTime.AutoSize = true;
            this.lblResultTime.Location = new System.Drawing.Point(163, 143);
            this.lblResultTime.Name = "lblResultTime";
            this.lblResultTime.Size = new System.Drawing.Size(0, 13);
            this.lblResultTime.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 168);
            this.Controls.Add(this.lblResultTime);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudMessagesSent);
            this.Controls.Add(this.btnSendMessages);
            this.Controls.Add(this.locationComboBox);
            this.Controls.Add(this.stateComboBox);
            this.Name = "Form1";
            this.Text = "Table Storage Tester";
            ((System.ComponentModel.ISupportInitialize)(this.nudMessagesSent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.ComboBox locationComboBox;
        private System.Windows.Forms.Button btnSendMessages;
        private System.Windows.Forms.NumericUpDown nudMessagesSent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblResultTime;
    }
}

