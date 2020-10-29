namespace ColorPickerSocket_Client
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIPClient = new System.Windows.Forms.TextBox();
            this.txtPortClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelColorSelected = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRedNumber = new System.Windows.Forms.TextBox();
            this.txtGreenNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBlueNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnColorPick = new System.Windows.Forms.Button();
            this.btnKirim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address";
            // 
            // txtIPClient
            // 
            this.txtIPClient.Location = new System.Drawing.Point(76, 9);
            this.txtIPClient.Name = "txtIPClient";
            this.txtIPClient.Size = new System.Drawing.Size(100, 20);
            this.txtIPClient.TabIndex = 1;
            this.txtIPClient.Text = "192.168.43.93";
            // 
            // txtPortClient
            // 
            this.txtPortClient.Location = new System.Drawing.Point(225, 9);
            this.txtPortClient.Name = "txtPortClient";
            this.txtPortClient.Size = new System.Drawing.Size(100, 20);
            this.txtPortClient.TabIndex = 3;
            this.txtPortClient.Text = "16355";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // panelColorSelected
            // 
            this.panelColorSelected.BackColor = System.Drawing.Color.DarkGray;
            this.panelColorSelected.Location = new System.Drawing.Point(12, 44);
            this.panelColorSelected.Name = "panelColorSelected";
            this.panelColorSelected.Size = new System.Drawing.Size(312, 203);
            this.panelColorSelected.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Red";
            // 
            // txtRedNumber
            // 
            this.txtRedNumber.Enabled = false;
            this.txtRedNumber.Location = new System.Drawing.Point(209, 278);
            this.txtRedNumber.Name = "txtRedNumber";
            this.txtRedNumber.ReadOnly = true;
            this.txtRedNumber.Size = new System.Drawing.Size(100, 20);
            this.txtRedNumber.TabIndex = 6;
            // 
            // txtGreenNumber
            // 
            this.txtGreenNumber.Enabled = false;
            this.txtGreenNumber.Location = new System.Drawing.Point(209, 326);
            this.txtGreenNumber.Name = "txtGreenNumber";
            this.txtGreenNumber.ReadOnly = true;
            this.txtGreenNumber.Size = new System.Drawing.Size(100, 20);
            this.txtGreenNumber.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Green";
            // 
            // txtBlueNumber
            // 
            this.txtBlueNumber.Enabled = false;
            this.txtBlueNumber.Location = new System.Drawing.Point(209, 374);
            this.txtBlueNumber.Name = "txtBlueNumber";
            this.txtBlueNumber.ReadOnly = true;
            this.txtBlueNumber.Size = new System.Drawing.Size(100, 20);
            this.txtBlueNumber.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Blue";
            // 
            // btnColorPick
            // 
            this.btnColorPick.Location = new System.Drawing.Point(58, 300);
            this.btnColorPick.Name = "btnColorPick";
            this.btnColorPick.Size = new System.Drawing.Size(75, 23);
            this.btnColorPick.TabIndex = 11;
            this.btnColorPick.Text = "Color pick";
            this.btnColorPick.UseVisualStyleBackColor = true;
            this.btnColorPick.Click += new System.EventHandler(this.btnColorPick_Click);
            // 
            // btnKirim
            // 
            this.btnKirim.Enabled = false;
            this.btnKirim.Location = new System.Drawing.Point(58, 348);
            this.btnKirim.Name = "btnKirim";
            this.btnKirim.Size = new System.Drawing.Size(75, 23);
            this.btnKirim.TabIndex = 12;
            this.btnKirim.Text = "Kirim";
            this.btnKirim.UseVisualStyleBackColor = true;
            this.btnKirim.Click += new System.EventHandler(this.btnKirim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 409);
            this.Controls.Add(this.btnKirim);
            this.Controls.Add(this.btnColorPick);
            this.Controls.Add(this.txtBlueNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGreenNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRedNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPortClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIPClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelColorSelected);
            this.Name = "Form1";
            this.Text = "Color Picker Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIPClient;
        private System.Windows.Forms.TextBox txtPortClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelColorSelected;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRedNumber;
        private System.Windows.Forms.TextBox txtGreenNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBlueNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnColorPick;
        private System.Windows.Forms.Button btnKirim;
    }
}

