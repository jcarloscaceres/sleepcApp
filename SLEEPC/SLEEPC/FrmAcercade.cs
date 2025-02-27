using System;
using System.Windows.Forms;

namespace SLEEPC
{
    public partial class FrmAcercade : Form
    {
        public FrmAcercade()
        {
            InitializeComponent();
        }

        private void LnkInstagram_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/jcx.dev/");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:jccaceres08@gmail.com");
        }

        private void LknGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/jcarloscaceres");
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAcercade_Load(object sender, EventArgs e)
        {

        }
    }
}
