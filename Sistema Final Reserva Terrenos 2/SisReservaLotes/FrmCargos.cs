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
    public partial class FrmCargos : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public FrmCargos()
        {
            InitializeComponent();
            btnmodificar.Visible = false;
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
            this.txtcargo.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
        }
        private void Habilitar(bool valor)
        {

            this.txtCodigo.Enabled = valor;
            this.txtDescripcion.Enabled = valor;
            this.txtcargo.Enabled = valor;
            this.cbEstado.Enabled = valor;
        }
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }

        }
        private void OcultarColumnas()
        {
            this.dgvRegistros.Columns[0].Visible = false;
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

        // solo numeros

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
            this.dgvRegistros.DataSource = NCargos.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dgvRegistros.Rows.Count);
        }
        private void Buscar()
        {
            this.dgvRegistros.DataSource = NCargos.Buscar(this.txtBuscarCargo.Text, this.cbBuscarEstado.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dgvRegistros.Rows.Count);
        }
        private void FrmCargos_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            errorIcono.Clear();
            txtCodigo.Visible = true;
            label10.Visible = true;
            dgvRegistros.Enabled = true;
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (this.txtcargo.Text == string.Empty || this.txtDescripcion.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(txtDescripcion, "Ingrese el nombre");
                    errorIcono.SetError(txtcargo, "Ingrese el apellido");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        Rpta = NCargos.Insertar(
                        this.txtcargo.Text,             
                        Convert.ToDateTime(DateTime.Now.ToShortTimeString()),
                        "ACTIVO",
                        this.txtDescripcion.Text
                        );
                    }
                    else
                    {
                        Rpta = NCargos.Editar(Convert.ToInt32(txtCodigo.Text),
                        this.txtcargo.Text,
                        this.cbEstado.Text,
                        this.txtDescripcion.Text
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
                this.txtCodigo.Enabled = false;
                dgvRegistros.Enabled = false;

                errorIcono.SetError(txtcargo, "Ingrese el nombre");
                errorIcono.SetError(cbEstado, "Ingrese el nombre");
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el registro a Modificar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvRegistros_Click(object sender, EventArgs e)
        {
            this.txtCodigo.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["CodigoC"].Value);
            this.txtcargo.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Cargo"].Value);
            this.cbEstado.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Estado"].Value);
            this.txtDescripcion.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Descripcion"].Value);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtcargo.Focus();
            dgvRegistros.Enabled = false;
            txtCodigo.Visible = false;
            label10.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtCodigo.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.txtCodigo.Enabled = false;
                dgvRegistros.Enabled = false;

                errorIcono.SetError(txtcargo, "Ingrese el nombre");
                errorIcono.SetError(cbEstado, "Ingrese el nombre");
                errorIcono.SetError(txtDescripcion, "Ingrese el nombre");
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el registro a Modificar");
            }
        }

        private void BtnEliminar_Click_1(object sender, EventArgs e)
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
                    Opcion = MessageBox.Show("Estas seguro de eliminar este Funcionario", "Sistema de Reservas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (Opcion == DialogResult.OK)
                    {
                        string Rpta = "";
                        Rpta = NCargos.Eliminar(Convert.ToInt32(txtCodigo.Text));

                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se Eliminó Correctamente el registro");
                        }
                        else
                        {
                            this.MensajeError("No se pueden eliminar resitros que tengan referencias" + Rpta);
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

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
