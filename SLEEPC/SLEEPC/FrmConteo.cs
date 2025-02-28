using System;
using System.Media;
using System.Windows.Forms;

namespace SLEEPC
{

    public partial class FrmConteo : Form
    {
        public int a = 29;
        public int b = 100 / 30;
        public SoundPlayer snd = new SoundPlayer(Properties.Resources.SLEEPC_SOUND_EDIT);
        public bool IsSnd;
        public int Accion;
        public FrmConteo()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            IsSnd = Properties.Settings.Default.CSonido;
            if (IsSnd)
            {
                snd.Play();
            }

            Accion = Properties.Settings.Default.CFuncion;
            TTempo.Enabled = true;
            TTempo.Start();
           
        }

        private void Confirmar()
        {
            TTempo.Stop();
            TTempo.Enabled = false;
            a = 29;
            Properties.Settings.Default.CMConteo = true;
            Close();
        }

        private void Cumplimiento()
        {
            PbBarra.Value = 0;
            TTempo.Stop();
            TTempo.Enabled = false;
            

            switch (Accion)
            {
                case 0:
                    Properties.Settings.Default.CMConteo = true;
                    System.Diagnostics.Process.Start("shutdown", "/s /t 0");
                    //MessageBox.Show("Se apaga la PC");
                    break;
                case 1:
                    Properties.Settings.Default.CMConteo = false;
                    Application.SetSuspendState(PowerState.Suspend, true, true);
                    //MessageBox.Show("Se suspende la PC");
                    break;
                case 2:
                    Properties.Settings.Default.CMConteo = false;
                    System.Diagnostics.Process.Start("rundll32.exe", "user32.dll,LockWorkStation");
                    //MessageBox.Show("Se bloquea la PC");

                    break;
            }

            a = 29;
            Close();
        }

        private void TTempo_Tick(object sender, EventArgs e)
        {
            PbBarra.Value -= b;
            a--;
            LblConteo.Text = a.ToString("00");

            if(a == 0)
            {
                Cumplimiento();
            }
        }

        private void BtnConteo_Click(object sender, EventArgs e)
        {
            Confirmar();
        }

        private void FrmConteo_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
