using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;

namespace SisReservaLotes
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Construccion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Construccion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == string.Empty)
            {
                MensajeError("Ingrese su Usuario");
                this.txtUsuario.Focus();
            }
            else if (this.txtPassword.Text == string.Empty)
            {
                MensajeError("Ingrese su Contraseña");
                this.txtPassword.Focus();
            }
            else
            {

                DataTable Datos = Capa_Negocio.NUsuario.LOGIN(this.txtUsuario.Text, this.txtPassword.Text);
                if (Datos.Rows.Count == 0)
                {
                    MessageBox.Show("No tiene Acceso al Sistema", "System Construction", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    FrmPrincipal Menu = new FrmPrincipal();
                    Menu.Codigo = Datos.Rows[0][0].ToString();
                    Menu.Apellido = Datos.Rows[0][2].ToString();
                    Menu.Nombre = Datos.Rows[0][1].ToString();
                    Menu.Acceso = Datos.Rows[0][3].ToString();
                    Menu.Show();
                    this.Hide();


                }
            }
        }

        private void PictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnIngresar_Click_1(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == string.Empty)
            {
                MensajeError("Ingrese su Usuario");
                this.txtUsuario.Focus();
            }
            else if (this.txtPassword.Text == string.Empty)
            {
                MensajeError("Ingrese su Contraseña");
                this.txtPassword.Focus();
            }
            else
            {

                DataTable Datos = Capa_Negocio.NUsuario.LOGIN(this.txtUsuario.Text, this.txtPassword.Text);
                if (Datos.Rows.Count == 0)
                {
                    MessageBox.Show("No tiene Acceso al Sistema", "System Construction", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    FrmPrincipal Menu = new FrmPrincipal();
                    Menu.Codigo = Datos.Rows[0][0].ToString();
                    Menu.Apellido = Datos.Rows[0][2].ToString();
                    Menu.Nombre = Datos.Rows[0][1].ToString();
                    Menu.Acceso = Datos.Rows[0][3].ToString();
                    Menu.Show();
                    this.Hide();


                }
            }
    }
}}
