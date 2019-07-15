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
    public partial class FrmCliente : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public FrmCliente()
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
            this.txtTelefono.Text = string.Empty;
            this.txtApellidos.Text = string.Empty;
            this.txtCI.Text = string.Empty;
            this.txtPais.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            
        }
        private void Habilitar(bool valor)
        {

            this.txtCodigo.Enabled = valor;
            this.txtNombre.Enabled = valor;
            this.txtApellidos.Enabled = valor;
            this.txtDireccion.Enabled = valor;
            this.cbSexo.Enabled = valor;
            this.txtCI.Enabled = valor;
            this.txtPais.Enabled = valor;
            this.cbSexo.Enabled = valor;
            this.txtTelefono.Enabled = valor;
            this.txtEdad.Enabled = valor;
            this.txtEmail.Enabled = valor;
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
                this.btnEliminar.Enabled = true;
                this.btnGuardar.Enabled = false;
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
            this.dgvRegistros.DataSource = NCliente.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dgvRegistros.Rows.Count);
        }
        private void Buscar()
        {
            this.dgvRegistros.DataSource = NCliente.Buscar(this.txtBuscarNombre.Text, this.txtBuscarSexo.Text, this.txtBuscarCI.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dgvRegistros.Rows.Count);
        }
        private void FrmCliente_Load(object sender, EventArgs e)
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

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (this.txtCodigo.Text == string.Empty)
            {
                this.MensajeError("seleccione un registro");
            }
            else
            {

                this.IsEditar = true;
                this.Botones();
                this.txtEmail.Enabled = false;
                this.txtCodigo.Enabled = false;
                this.txtNombre.Enabled = false;
                this.txtApellidos.Enabled = false;
                this.cbSexo.Enabled = false;
                this.txtCI.Enabled = false;
                this.txtPais.Enabled = false;
                this.txtDireccion.Enabled = false;
                this.txtTelefono.Enabled = false;

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (this.txtNombre.Text == string.Empty || this.txtApellidos.Text == string.Empty || this.txtTelefono.Text == string.Empty || this.txtEdad.Text == string.Empty || this.txtCI.Text == string.Empty || this.txtDireccion.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(txtNombre, "Ingrese el nombre");
                    errorIcono.SetError(txtApellidos, "Ingrese el apellido");
                    errorIcono.SetError(txtDireccion, "Ingrese el password");
                    errorIcono.SetError(cbSexo, "Ingrese el usuaurio");
                    errorIcono.SetError(txtTelefono, "Ingrese el telefono");
                    errorIcono.SetError(txtCI, "Ingrese el usuaurio");
                    errorIcono.SetError(txtEdad, "Ingrese el telefono");
                    errorIcono.SetError(dtFechaNac, "Ingrese el telefono");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        Rpta = NCliente.Insertar(
                        this.txtNombre.Text,
                        this.txtApellidos.Text,
                        this.cbSexo.Text,
                        Convert.ToInt32(this.txtEdad.Text),
                        this.dtFechaNac.Value,
                        Convert.ToInt32(this.txtCI.Text),
                        Convert.ToInt32(this.txtTelefono.Text),
                        this.txtPais.Text,
                        this.txtDireccion.Text,
                        this.txtEmail.Text,
                        Convert.ToDateTime(DateTime.Now.ToShortTimeString())                        
                        );
                    }
                    else
                    {
                        Rpta = NCliente.Editar(Convert.ToInt32(txtCodigo.Text),
                       this.txtNombre.Text,
                        this.txtApellidos.Text,
                        this.cbSexo.Text,
                        Convert.ToInt32(this.txtEdad.Text),
                        this.dtFechaNac.Value,
                        Convert.ToInt32(this.txtCI.Text),
                        Convert.ToInt32(this.txtTelefono.Text),
                        this.txtPais.Text,
                        this.txtDireccion.Text,
                        this.txtEmail.Text
                        );
                    }

                    if (Rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se insertó de forma correcta el registro");
                            errorIcono.Clear();
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
                    txtCodigo.Visible = true;
                    label10.Visible = true;
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
                this.txtNombre.Enabled = false;
                this.txtApellidos.Enabled = false;
                this.cbSexo.Enabled = false;
                this.txtCI.Enabled = false;

                errorIcono.SetError(txtDireccion, "Ingrese el nombre");
                errorIcono.SetError(txtTelefono, "Ingrese el apellido");
                errorIcono.SetError(txtPais, "Ingrese el pais");
                errorIcono.SetError(txtDireccion, "Ingrese el pais");
                errorIcono.SetError(txtEmail, "Ingrese el pais");
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
            this.txtCodigo.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["CodigoCL"].Value);
            this.txtNombre.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Nombres"].Value);
            this.txtApellidos.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Apellidos"].Value);
            this.cbSexo.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Sexo"].Value);
            this.txtDireccion.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Direccion"].Value);
            this.txtTelefono.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Telefono"].Value);
            this.txtPais.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Pais"].Value);
            this.txtCI.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["CI"].Value);
            this.txtEdad.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Edad"].Value);
            this.txtEmail.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Email"].Value);
            this.dtFechaNac.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Fecha_Nacimiento"].Value);
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
                        Rpta = NCliente.Eliminar(Convert.ToInt32(txtCodigo.Text));

                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se Eliminó Correctamente el registro");
                        }
                        else
                        {
                            this.MensajeError("No se pueden eliminar Clientes que tengan reservas pendientes");
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

       

        private void txtBuscarCI_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarCI.Text == string.Empty)
            {
                this.Buscar();
            }
            else
            {
                this.Buscar();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.Mostrar();
            this.txtBuscarSexo.Text = string.Empty;
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.sololetras(e);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.sololetras(e);
        }

        private void txtPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.sololetras(e);
        }

        private void txtCI_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.SoloNumeros(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.SoloNumeros(e);
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.SoloNumeros(e);
        }

        private void txtBuscarCI_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.SoloNumeros(e);
        }

        private void txtBuscarNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.sololetras(e);
        }

        private void cbSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtBuscarSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtBuscarSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtBuscarSexo.Text == string.Empty)
            {
                this.Buscar();
            }
            else
            {
                this.Buscar();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtCodigo.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.txtCodigo.Enabled = false;
                this.txtNombre.Enabled = false;
                this.txtApellidos.Enabled = false;
                this.cbSexo.Enabled = false;
                this.txtCI.Enabled = false;

                errorIcono.SetError(txtDireccion, "Ingrese el nombre");
                errorIcono.SetError(txtTelefono, "Ingrese el apellido");
                errorIcono.SetError(txtDireccion, "Ingrese el pais");
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el registro a Modificar");
            }
        }
    }
}
