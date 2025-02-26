using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLEEPC
{
    public partial class FrmConfig : Form
    {
        //Declaracin de variables para guardar y recuperar datos de configuración
        public string Hora;
        public string Min;
        public string Per;
        public int Inter;
        public string HoraCompleta;
        public bool Son;
        public enum SetFuncion
        {
            A, //0
            S, //1
            B //2
        }

        public string RFuncion;



        public FrmConfig()
        {
            InitializeComponent();
        }

        //Metodo para descargar los datos de configuración
        private void DescargarData()
        {
            //variable que traiga la hora completa desde la configuracion previamente guardada
            string HoraDeConfig = Properties.Settings.Default.CHora;

            //Arreglo Split para separar la string recibida en las distintas secciones para agregar a sus respectivas variables
            string[] partes = HoraDeConfig.Split(new char[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string DPer;

            NudHora.Value = Convert.ToDecimal(partes[0]);
            NudMinutos.Value = Convert.ToDecimal(partes[1]);
            DPer = partes[3];

            if (DPer == "a.")
            {
                RbAm.Checked = true;
                RbPm.Checked = false;
            }

            else if(DPer == "p.")
            {
                RbAm.Checked = false;
                RbPm.Checked = true;
            }

            NudIntervalo.Value = Convert.ToDecimal(Properties.Settings.Default.CIntervalo);
            ChkSonido.Checked = Properties.Settings.Default.CSonido;

            SetFuncion accion = (SetFuncion)Properties.Settings.Default.CFuncion;
            switch (accion)
            {
                case SetFuncion.A:
                    RbApagar.Checked = true;
                    break;

                case SetFuncion.B:
                    RbBloquear.Checked = true;
                    break;

                case SetFuncion.S:
                    RbSuspender.Checked = true;
                    break;
            }


        }

        //metodo para asignar los valores a las variables para que se pueda cargar a las configuraciones
        private void SettearData()
        {
            Hora = NudHora.Value.ToString("00");
            Min = NudMinutos.Value.ToString("00");
            Inter = Convert.ToInt32(NudIntervalo.Value);
            
            //Sonido
            if (ChkSonido.Checked)
            {
                Son = true;
            }
            else
            {
                Son = false;
            }


            //Periodo am/pm
            if (RbAm.Checked)
            {
                Per = "a.";
            }
            else if (RbPm.Checked)
            {
                Per = "p.";
            }

            //se asigna una hora completa fusionando las variables correspondientes en tipo string
            HoraCompleta = Hora + ":" + Min + ":" + "00" + " " + Per;

        }

        //metodo para guardar los datos de configuracion.
        private void GuardarConfig()
        {
            Properties.Settings.Default.CHora = HoraCompleta;
            Properties.Settings.Default.CIntervalo = Inter;
            Properties.Settings.Default.CSonido = Son;

            //funcion que va a realizar la app (bloquear, suspender o apagar)
            if (RbApagar.Checked == true)
            {
                Properties.Settings.Default.CFuncion = (int)SetFuncion.A;
                RFuncion = "Apagar PC";
            }
            else if (RbSuspender.Checked == true)
            {
                Properties.Settings.Default.CFuncion = (int)SetFuncion.S;
                RFuncion = "Suspender PC";
            }
            else if (RbBloquear.Checked == true)
            {
                Properties.Settings.Default.CFuncion = (int)SetFuncion.B;
                RFuncion = "Bloquear Pantalla";
            }

            //Guardar valores de configuracion.
            Properties.Settings.Default.Save();

            MessageBox.Show("Hora de Activación establecida a las " + HoraCompleta + ";" + " " + "Con un intervalo de verificación en " + Inter + ";" + " " + "minutos "+ ";" + " " + "Acción a realizar; " + RFuncion, "Mensaje SLEEPC",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        //Boton guardar
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            SettearData();
            GuardarConfig();
            Close();
        }

        //Boton cancelar
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Evento de carga del formulario
        private void FrmConfig_Load(object sender, EventArgs e)
        {
            DescargarData();
        }
    }
}
