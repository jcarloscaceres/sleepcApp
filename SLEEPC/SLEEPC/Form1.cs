using System;
using System.Drawing;
using System.Windows.Forms;

namespace SLEEPC
{
    public partial class Form1 : Form
    {
        public string Hora_Establecida;
        public int Down;
        private bool isDragging = false;
        private Point lastCursor;
        private bool Verifi;

        public Form1()
        {
            InitializeComponent();
        }

        //metodo para mostrar diferentes mensajes en la notificaciones
        private void Notifica(string mensaje)
        {
            notifyIcon1.BalloonTipText = mensaje;
            notifyIcon1.ShowBalloonTip(3000);
            
        }

        //opciones para el menu contextual de click derecho
        #region
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var acercaDe = new FrmAcercade())
            {
                acercaDe.ShowDialog();
            }
            
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuestraConfig();
        }

        private void ocultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Notifica("SLEEPC se sigue ejecutándo en segundo plano. Si desea cerrar la aplicación haga click derecho en el ícono y seleccione <Cerrar>");
          
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var acercaDe = new FrmAcercade())
            {
                acercaDe.ShowDialog();
            }
        }

        private void configuraciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MuestraConfig();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
        private void ColocarFrm()
        {
            // Obtener tamaño de la pantalla
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            // Obtener tamaño del formulario
            int formWidth = this.Width;
            int formHeight = this.Height;

            // Calcular posición centrada horizontalmente y pegada abajo
            int x = (screenWidth - formWidth) / 2;
            int y = screenHeight - formHeight;

            // Establecer la posición del formulario
            this.Location = new Point(x, y);
        }

        //Cargar la data de la configuración
        private void CargaData()
        {
            Hora_Establecida = Properties.Settings.Default.CHora;
            Down = Properties.Settings.Default.CIntervalo * 60;
        }

        //metodo para mostrar la configuracion y luego cargar la data;
        private void MuestraConfig()
        {
            using (var Configuracion = new FrmConfig())
            {
                Configuracion.ShowDialog();
                CargaData();
            }
            
        }

        private void MuestraConteo()
        {
            using (var Conteo = new FrmConteo())
            {
                Conteo.ShowDialog();
            }
        }

        //timer que maneja la opacidad
        private void TOpacity_Tick(object sender, EventArgs e)
        {

            Opacity = ClientRectangle.Contains(PointToClient(Cursor.Position)) ? 0.9 : 0.2;

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // Iniciar el arrastre cuando se presiona el botón izquierdo del mouse
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = e.Location; // Guardar la ubicación del mouse al hacer clic
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // Mover el formulario si está siendo arrastrado
            if (isDragging)
            {
                // Calcular la nueva posición
                int deltaX = e.X - lastCursor.X;
                int deltaY = e.Y - lastCursor.Y;
                this.Location = new Point(this.Left + deltaX, this.Top + deltaY);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            // Detener el arrastre cuando se suelta el botón izquierdo del mouse
            isDragging = false;
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            MuestraConfig();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ColocarFrm();
            Verifi = false;
            CargaData();
        }

        private void TPrincipal_Tick(object sender, EventArgs e)
        {
            //Establecer la hora actual del sistema con formato cadena de texto
            LblHoraActual.Text = DateTime.Now.ToString("hh:mm:ss t.");

            if(LblHoraActual.Text == Hora_Establecida)
            {
                Notifica("SLEEPC se ha activado.  Verificación en: " + Down / 60 + " minutos");
                Properties.Settings.Default.CMConteo = true;
                Verifi = true;
            }

            if(Verifi == true)
            {
                Down--;

                if(Down == 0)
                {
                    Verifi = false;

                    if (Properties.Settings.Default.CMConteo == true)
                    {
                        MuestraConteo();
                        Down = 0;
                        CargaData();
                        Verifi = true;
                    }

                }
            }
        }
    }
}
