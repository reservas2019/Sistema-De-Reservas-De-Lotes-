using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisReservaLotes
{
    public partial class FrmPrincipal : Form
    {
        public string Codigo = "";
        public string Apellido = "";
        public string Nombre = "";
        public string Acceso = "";
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario frm = new FrmUsuario();
            frm.ShowDialog();
        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            FrmCargos frm = new FrmCargos();
            frm.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin Login = new FrmLogin();
            Login.Show();
            this.Hide();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente();
            frm.ShowDialog();
        }
        private void GestionUsuario()
        {
            if (Acceso == "ADMINISTRADOR")
            {
                this.moduloUsuarioToolStripMenuItem.Visible = true;
                this.btnCliente.Visible = true;

                this.btnModUrbanizacion.Visible = true;
                this.moduloRToolStripMenuItem.Visible = true;
                this.reportesToolStripMenuItem.Visible = true;

                lbngreso.Text = Acceso;
                lbingresar2.Text = Apellido;
            }
            else if (Acceso == "VENDEDOR")
            {
                this.moduloUsuarioToolStripMenuItem.Visible = false;
                this.btnCliente.Visible = false;

                this.btnModUrbanizacion.Visible = false;
                this.moduloRToolStripMenuItem.Visible = true;
                this.reportesToolStripMenuItem.Visible = false;

                lbngreso.Text = Acceso;
                lbingresar2.Text = Apellido;
            }
            else if (Acceso == "SECRETARIA")
            {
                this.moduloUsuarioToolStripMenuItem.Visible = false;
                this.btnCliente.Visible = false;

                this.btnModUrbanizacion.Visible = false;
                this.moduloRToolStripMenuItem.Visible = false;
                this.reportesToolStripMenuItem.Visible = true;

                lbngreso.Text = Acceso;
                lbingresar2.Text = Apellido;
            }
            else
            {
                this.moduloUsuarioToolStripMenuItem.Visible = false;
                this.btnCliente.Visible = false;

                this.btnModUrbanizacion.Visible = false;
                this.moduloRToolStripMenuItem.Visible = false;
                this.reportesToolStripMenuItem.Visible = false;

                lbngreso.Text = Acceso;
                lbingresar2.Text = Apellido;

                label1.Text = "Bienvenido al sistema visitante";
            }
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.GestionUsuario();
        }

        private void btnModUrbanizacion_Click(object sender, EventArgs e)
        {
           
        }

        private void gestionarUrbanizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUrbanizacion frm = new FrmUrbanizacion();
            frm.ShowDialog();
        }

        private void gestionarTerrenoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLotes frm = FrmLotes.GetInstancia();
            frm.ShowDialog();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ReservacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ModuloRToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ConsultarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultasReservas frm = new FrmConsultasReservas();
            frm.ShowDialog();
        }

        private void NuevaReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReservas frm = FrmReservas.GetInstancia();
            frm.ShowDialog();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Lbngreso_Click(object sender, EventArgs e)
        {

        }

        private void Lbingresar2_Click(object sender, EventArgs e)
        {

        }
        private int imageNumber = 1;
        private void ProximaImagen()
        {
            if (imageNumber == 5)
            {
                imageNumber = 1;

            }
            pictureBox1.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);
            imageNumber++;
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
