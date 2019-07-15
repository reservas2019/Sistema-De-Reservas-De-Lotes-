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
    public partial class FrmLotes : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        private static FrmLotes _instancia;

        public static FrmLotes GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new FrmLotes();
            }
            return _instancia;
        }

        public void setUrbanizacion(string codigo, string urbanizacion)
        {
            this.txtCodigoUrbani.Text = codigo;
            this.txtUrbanizacion.Text = urbanizacion;
        }
        public FrmLotes()
        {
            InitializeComponent();
            this.txtCodigoUrbani.Visible = false;
            btnmodificar.Visible = true;
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
            this.txtUrbanizacion.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
            this.txtNro.Text = string.Empty;
            this.txtSuperficie.Text = string.Empty;
            this.txtPrecio.Text = string.Empty;
            this.txtSector.Text = string.Empty;
            this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pxImagen.Image = global::SisReservaLotes.Properties.Resources.blanco;
        }
        private void Habilitar(bool valor)
        {
            this.txtCodigo.Enabled = valor;
            this.txtDescripcion.Enabled = valor;
            this.txtUrbanizacion.Enabled = valor;
            this.txtNro.Enabled = valor;
            this.txtSuperficie.Enabled = valor;
            this.txtSector.Enabled = valor;
            this.txtPrecio.Enabled = valor;
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

        private void OcultarColumnas()
        {
            this.dgvRegistros.Columns[0].Visible = false;
            this.dgvRegistros.Columns[1].Visible = false;
        }
        private void Mostrar()
        {
            this.dgvRegistros.DataSource = NLotes.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dgvRegistros.Rows.Count);
        }
        private void Buscar()
        {
            this.dgvRegistros.DataSource = NLotes.Buscar(this.cbBuscarEstado.Text,this.txtBuscarNro.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dgvRegistros.Rows.Count);
        }
        private void FrmLotes_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void btnBuscarCodi_Click(object sender, EventArgs e)
        {
            FrmVistaUrbanizacion frm = new FrmVistaUrbanizacion();
            frm.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (this.txtUrbanizacion.Text == string.Empty || this.txtPrecio.Text == string.Empty || this.txtSuperficie.Text == string.Empty || this.txtNro.Text == string.Empty || this.txtSector.Text == string.Empty )
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(txtDescripcion, "Ingrese el nombre");
                    errorIcono.SetError(txtPrecio, "Ingrese el password");
                    errorIcono.SetError(txtSuperficie, "Ingrese el usuaurio");
                    errorIcono.SetError(txtNro, "Ingrese el telefono");
                    errorIcono.SetError(txtSector, "Ingrese el usuaurio");
                    errorIcono.SetError(txtUrbanizacion, "Ingrese el telefono");

                }
                else
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.pxImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] imagen = ms.GetBuffer();
                    if (this.IsNuevo)
                    {
                        Rpta = NLotes.Insertar(
                        Convert.ToInt32(this.txtCodigoUrbani.Text),
                        this.txtSuperficie.Text,
                        Convert.ToInt32(this.txtNro.Text),
                        "HABILITADO",
                        this.txtDescripcion.Text,
                        this.txtPrecio.Text,
                        this.txtSector.Text,
                        imagen
                        );
                    }
                    else
                    {
                        Rpta = NLotes.Editar(Convert.ToInt32(this.txtCodigo.Text),
                        Convert.ToInt32(this.txtCodigoUrbani.Text),
                        this.txtSuperficie.Text,
                        Convert.ToInt32(this.txtNro.Text),
                        this.cbEstado.Text,
                        this.txtDescripcion.Text,
                        this.txtPrecio.Text,
                        this.txtSector.Text,
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
                this.txtUrbanizacion.Enabled = false;
                this.txtSuperficie.Enabled = false;
                this.txtSector.Enabled = false;
                this.txtNro.Enabled = false;
                this.cbEstado.Enabled = false;


                errorIcono.SetError(txtPrecio, "Ingrese el precio");
                errorIcono.SetError(txtDescripcion, "Ingrese el descripcion");
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
            this.txtCodigo.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["CodigoL"].Value);
            this.txtUrbanizacion.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Nombre"].Value);
            this.txtSuperficie.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Superficie"].Value);
            this.txtNro.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Nro_Lote"].Value);
            this.cbEstado.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Estado"].Value);
            this.txtDescripcion.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Descripcion"].Value);
            this.txtPrecio.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Precio"].Value);
            this.txtSector.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Sector"].Value);
            this.txtCodigoUrbani.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["CodigoUR"].Value);

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
                    Opcion = MessageBox.Show("Estas seguro de eliminar este Terreno del Sistema", "Sistema de Reservas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

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
                            this.MensajeError("No se pueden eliminar resitros que tengan referencias con otros datos" + Rpta);
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

        private void txtBuscarNro_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarNro.Text == "")
            {
                this.Mostrar();
            }
            else
            {
                this.Buscar();
            }
        }

        private void cbBuscarEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBuscarEstado.Text == string.Empty)
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

        private void txtUrbanizacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
        }

        private void cbBuscarEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
        }

        private void txtNro_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.SoloNumeros(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtBuscarNro_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.SoloNumeros(e);
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololetras(e);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.txtPrecio.Text = "$";
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtUrbanizacion.Focus();
            txtCodigo.Visible = false;
            label10.Visible = false;
            dgvRegistros.Enabled = false;
        }

        private void txtUrbanizacion_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cambiarEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
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

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                this.pxImagen.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pxImagen.Image = global::SisReservaLotes.Properties.Resources.blanco;
        }

        private void DgvRegistros_DoubleClick(object sender, EventArgs e)
        {

        }

        private void PxImagen_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtCodigo.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.txtUrbanizacion.Enabled = false;
                this.txtSuperficie.Enabled = false;
                this.txtSector.Enabled = false;
                this.txtNro.Enabled = false;


                errorIcono.SetError(txtPrecio, "Ingrese el precio");
                errorIcono.SetError(txtDescripcion, "Ingrese el descripcion");
                errorIcono.SetError(cbEstado, "Ingrese el descripcion");
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el registro a Modificar");
            }
        }
    }
}
