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
    public partial class FrmUrbanizacion : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public FrmUrbanizacion()
        {
            InitializeComponent();
            this.btnmodificar.Visible = false;
        }
        private void OcultarColumnas()
        {
            this.dgvRegistros.Columns[0].Visible = false;
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Reservas de Lotes", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Reservas de Lotes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        ////Limpiar todos los controles del formulario
        private void Limpiar()
        {
            this.txtCodigo.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtCiudad.Text = string.Empty;
            this.txtSuperficie.Text = string.Empty;
            this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pxImagen.Image = global::SisReservaLotes.Properties.Resources.blanco;

        }
        private void Habilitar(bool valor)
        {
            this.txtCodigo.Enabled = valor;
            this.txtNombre.Enabled = valor;
            this.txtCiudad.Enabled = valor;
            this.txtDireccion.Enabled = valor;
            this.txtSuperficie.Enabled = valor;
            this.btnAgregarImagen.Enabled = valor;
            this.btnQuitarImagen.Enabled = valor;
        }
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEliminar.Enabled = true;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }

        }
        public void sololetras(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void SoloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }

                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private void Mostrar()
        {
            this.dgvRegistros.DataSource = NUrbanizacion.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dgvRegistros.Rows.Count);
        }
        private void Buscar()
        {
            this.dgvRegistros.DataSource = NUrbanizacion.Buscar(this.txtBuscarNombre.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dgvRegistros.Rows.Count);
        }
        private void FrmUrbanizacion_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtNombre.Focus();
            txtCodigo.Visible = false;
            label10.Visible = false;
            dgvRegistros.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            errorIcono.Clear();
            dgvRegistros.Enabled = true;
            txtCodigo.Visible = true;
            label10.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (this.txtNombre.Text == string.Empty || this.txtCiudad.Text == string.Empty || this.txtSuperficie.Text == string.Empty || txtDireccion.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(txtNombre, "Ingrese el nombre");
                    errorIcono.SetError(txtDireccion, "Ingrese el password");
                    errorIcono.SetError(txtSuperficie, "Ingrese el usuaurio");
                    errorIcono.SetError(txtCiudad, "Ingrese el telefono");
                    errorIcono.SetError(btnAgregarImagen, "Ingrese el telefono");

                }
                else
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.pxImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] imagen = ms.GetBuffer();
                    if (this.IsNuevo)
                    {
                        Rpta = NUrbanizacion.Insertar(
                        this.txtNombre.Text,
                        this.txtDireccion.Text,
                        this.txtCiudad.Text,
                        this.txtSuperficie.Text,
                        imagen
                        );
                    }
                    else
                    {
                        Rpta = NUrbanizacion.Editar(Convert.ToInt32(this.txtCodigo.Text),
                        this.txtNombre.Text,
                        this.txtDireccion.Text,
                        this.txtCiudad.Text,
                        this.txtSuperficie.Text,
                        imagen
                        );
                    }

                    if (Rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se insertó de forma correcta el registro");
                            errorIcono.Clear();
                            txtCodigo.Visible = true;
                            label10.Visible = true;
                        }
                        else
                        {
                            this.MensajeOk("Se actualizó de forma correcta el registro");
                            errorIcono.Clear();

                        }

                    }
                    else
                    {

                        this.MensajeError(Rpta);
                    }
                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();
                    dgvRegistros.Enabled = true;

                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
             if (!this.txtCodigo.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.txtCiudad.Enabled = false;
                this.txtDireccion.Enabled = false;
            

                errorIcono.SetError(txtNombre, "Ingrese el nombre");
                errorIcono.SetError(txtSuperficie, "Ingrese el apellido");
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el registro a Modificar");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvRegistros_Click(object sender, EventArgs e)
        {
            this.txtCodigo.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["CodigoUR"].Value);
            this.txtNombre.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Nombre"].Value);
            this.txtDireccion.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Direccion"].Value);
            this.txtCiudad.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Ciudad"].Value);
            this.txtSuperficie.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Superficie"].Value);

            byte[] imagenBuffer = (byte[])this.dgvRegistros.CurrentRow.Cells["Imagen"].Value;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenBuffer);

            this.pxImagen.Image = Image.FromStream(ms);
            this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == string.Empty)
            {
                MensajeError("Seleccione un registro");
            }
            else
            {
                try
                {
                    DialogResult Opcion;
                    Opcion = MessageBox.Show("Estas seguro de eliminar este Cliente", "Sistema de Reservas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (Opcion == DialogResult.OK)
                    {
                        string Rpta = "";
                        Rpta = NUrbanizacion.Eliminar(Convert.ToInt32(txtCodigo.Text));

                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se Eliminó Correctamente el registro");
                        }
                        else
                        {
                            this.MensajeError("No se pueden eliminar esta Urbanizacion por que tiene lotes registrados");
                        }
                        this.Mostrar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarNombre.Text == "")
            {
                this.Mostrar();
            }
            else
            {
                this.Buscar();
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.sololetras(e);
        }

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.sololetras(e);
        }

        private void txtSuperficie_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.sololetras(e);
        }

        private void txtBuscarNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.sololetras(e);
        }

        private void BtnAgregarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                this.pxImagen.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void BtnQuitarImagen_Click(object sender, EventArgs e)
        {
            this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pxImagen.Image = global::SisReservaLotes.Properties.Resources.blanco;
        }

        private void BtnCambiarEstado_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtCodigo.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.txtCiudad.Enabled = false;
                this.txtDireccion.Enabled = false;


                errorIcono.SetError(txtNombre, "Ingrese el nombre");
                errorIcono.SetError(txtSuperficie, "Ingrese el apellido");
                errorIcono.SetError(label4, "Ingrese el apellido");
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el registro a Modificar");
            }
        }
    }
}
