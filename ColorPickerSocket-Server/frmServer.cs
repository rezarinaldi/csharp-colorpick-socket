using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPickerSocket_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            Thread thr = new Thread(listenSocket);
            if (txtIPServer.Text != "" && txtPortServer.Text != "")
            {
                thr.Start();
                btnListen.Enabled = false;
                txtIPServer.Enabled = false;
                txtPortServer.Enabled = false;
            }
            else
            {
                MessageBox.Show("Lengkapi port dan alamat IP terlebih dahulu !!!");
            }
        }

        private void listenSocket()
        {
            varGlobal.port = Int16.Parse(txtPortServer.Text); // konversi dari string ke integer
            varGlobal.alamatIPServer = txtIPServer.Text;
            SocketTCP.StartListening();
        }

        private void timerServer_Tick(object sender, EventArgs e)
        {
            if(varGlobal.terimapesandiserver.Length > 1)
            {
                backgroundColorPanel.BackColor = Color.Transparent;
                string[] data = varGlobal.terimapesandiserver.Trim().Split(',');
                txtRedNumber.Text = data[0];
                txtGreenNumber.Text = data[1];
                txtBlueNumber.Text = data[2];

                int r = 0;
                int g = 0;
                int b = 0;

                if(Int32.TryParse(txtRedNumber.Text, out r) 
                    && Int32.TryParse(txtGreenNumber.Text, out g)
                    && Int32.TryParse(txtBlueNumber.Text, out b))
                {
                    backgroundColorPanel.BackColor = Color.FromArgb(r, g, b);
                }
            }
        }
    }
}
