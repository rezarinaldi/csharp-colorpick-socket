using System;
using System.Text;
using System.Windows.Forms;

namespace ColorPickerSocket_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKirim_Click(object sender, EventArgs e)
        {
            varGlobal.alamatIPServer = txtIPClient.Text;
            varGlobal.port = Int16.Parse(txtPortClient.Text);
            StringBuilder color = new StringBuilder();
            color.Append(txtRedNumber.Text)
                .Append(",")
                .Append(txtGreenNumber.Text)
                .Append(",")
                .Append(txtBlueNumber.Text)
                .Append(",");
            SocketTCP.StartClient(color.ToString());
        }

        private void btnColorPick_Click(object sender, EventArgs e)
        {
            selectColor();
        }

        private void selectColor()
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.FullOpen = true;
            colorDialog.Color = backgroundColorPanel.BackColor;
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                txtRedNumber.Text = colorDialog.Color.R.ToString();
                txtGreenNumber.Text = colorDialog.Color.G.ToString();
                txtBlueNumber.Text = colorDialog.Color.B.ToString();

                backgroundColorPanel.BackColor = colorDialog.Color;
            }
            MessageBox.Show("RGB Warna yang didapat adalah: " + colorDialog.Color.R.ToString() + ", " + colorDialog.Color.G.ToString() + ", " + colorDialog.Color.B.ToString());

            if (btnKirim.Enabled.Equals(false))
            {
                btnKirim.Enabled = true;
            }
        }
    }
}
