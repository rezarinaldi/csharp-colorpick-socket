namespace ColorPickerSocket_Server
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
            this.components = new System.ComponentModel.Container();
            this.txtBlueNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGreenNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRedNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPortServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIPServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelColorSelected = new System.Windows.Forms.Panel();
            this.btnListen = new System.Windows.Forms.Button();
            this.timerServer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtBlueNumber
            // 
            this.txtBlueNumber.Enabled = false;
            this.txtBlueNumber.Location = new System.Drawing.Point(333, 322);
            this.txtBlueNumber.Name = "txtBlueNumber";
            this.txtBlueNumber.ReadOnly = true;
            this.txtBlueNumber.Size = new System.Drawing.Size(100, 20);
            this.txtBlueNumber.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Blue";
            // 
            // txtGreenNumber
            // 
            this.txtGreenNumber.Enabled = false;
            this.txtGreenNumber.Location = new System.Drawing.Point(193, 322);
            this.txtGreenNumber.Name = "txtGreenNumber";
            this.txtGreenNumber.ReadOnly = true;
            this.txtGreenNumber.Size = new System.Drawing.Size(100, 20);
            this.txtGreenNumber.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Green";
            // 
            // txtRedNumber
            // 
            this.txtRedNumber.Enabled = false;
            this.txtRedNumber.Location = new System.Drawing.Point(45, 322);
            this.txtRedNumber.Name = "txtRedNumber";
            this.txtRedNumber.ReadOnly = true;
            this.txtRedNumber.Size = new System.Drawing.Size(100, 20);
            this.txtRedNumber.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Red";
            // 
            // txtPortServer
            // 
            this.txtPortServer.Location = new System.Drawing.Point(299, 6);
            this.txtPortServer.Name = "txtPortServer";
            this.txtPortServer.Size = new System.Drawing.Size(100, 20);
            this.txtPortServer.TabIndex = 16;
            this.txtPortServer.Text = "16355";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Port";
            // 
            // txtIPServer
            // 
            this.txtIPServer.Location = new System.Drawing.Point(103, 6);
            this.txtIPServer.Name = "txtIPServer";
            this.txtIPServer.Size = new System.Drawing.Size(100, 20);
            this.txtIPServer.TabIndex = 14;
            this.txtIPServer.Text = "192.168.43.93";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "IP Address";
            // 
            // panelColorSelected
            // 
            this.panelColorSelected.BackColor = System.Drawing.Color.Transparent;
            this.panelColorSelected.Location = new System.Drawing.Point(14, 46);
            this.panelColorSelected.Name = "panelColorSelected";
            this.panelColorSelected.Size = new System.Drawing.Size(419, 213);
            this.panelColorSelected.TabIndex = 17;
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(208, 279);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(75, 23);
            this.btnListen.TabIndex = 24;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // timerServer
            // 
            this.timerServer.Enabled = true;
            this.timerServer.Tick += new System.EventHandler(this.timerServer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 354);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.txtBlueNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGreenNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRedNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPortServer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIPServer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelColorSelected);
            this.Name = "Form1";
            this.Text = "Color Picker Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBlueNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGreenNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRedNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPortServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIPServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelColorSelected;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Timer timerServer;
    }
}

