namespace UdpClient
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
            this.desIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.client_Log = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DestinationPort = new System.Windows.Forms.TextBox();
            this.SendTest = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SendingText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // desIP
            // 
            this.desIP.Location = new System.Drawing.Point(89, 9);
            this.desIP.Name = "desIP";
            this.desIP.Size = new System.Drawing.Size(100, 22);
            this.desIP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Destination IP";
            // 
            // client_Log
            // 
            this.client_Log.FormattingEnabled = true;
            this.client_Log.ItemHeight = 12;
            this.client_Log.Location = new System.Drawing.Point(13, 105);
            this.client_Log.Name = "client_Log";
            this.client_Log.Size = new System.Drawing.Size(258, 136);
            this.client_Log.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Destination Port";
            // 
            // DestinationPort
            // 
            this.DestinationPort.Location = new System.Drawing.Point(91, 40);
            this.DestinationPort.Name = "DestinationPort";
            this.DestinationPort.Size = new System.Drawing.Size(100, 22);
            this.DestinationPort.TabIndex = 5;
            // 
            // SendTest
            // 
            this.SendTest.Location = new System.Drawing.Point(197, 70);
            this.SendTest.Name = "SendTest";
            this.SendTest.Size = new System.Drawing.Size(75, 23);
            this.SendTest.TabIndex = 7;
            this.SendTest.Text = "Send Test";
            this.SendTest.UseVisualStyleBackColor = true;
            this.SendTest.Click += new System.EventHandler(this.SendTest_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sending Text";
            // 
            // SendingText
            // 
            this.SendingText.Location = new System.Drawing.Point(90, 71);
            this.SendingText.Name = "SendingText";
            this.SendingText.Size = new System.Drawing.Size(100, 22);
            this.SendingText.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SendingText);
            this.Controls.Add(this.SendTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DestinationPort);
            this.Controls.Add(this.client_Log);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.desIP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox desIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox client_Log;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DestinationPort;
        private System.Windows.Forms.Button SendTest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SendingText;
    }
}

