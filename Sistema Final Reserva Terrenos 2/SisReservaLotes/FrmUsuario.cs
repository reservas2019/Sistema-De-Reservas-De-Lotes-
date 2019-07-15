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
    public partial class FrmUsuario : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public FrmUsuario()
        {
            InitializeComponent();
            this.cargarCargos();
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
            this.txtNombre.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtApellidos.Text = string.Empty;
            this.txtUsuario.Text = string.Empty;
            this.txtPassword.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
        }
        private void Habilitar(bool valor)
        {
            
                this.txtCodigo.Enabled = valor;
                this.txtNombre.Enabled = valor;
                this.txtApellidos.Enabled = valor;
                this.txtDireccion.Enabled = valor;
                this.cbSexo.Enabled = valor;
                this.txtUsuario.Enabled = valor;
                this.txtPassword.Enabled = valor;
                this.cbSexo.Enabled = valor;
                this.txtTelefono.Enabled = valor;
                this.cbEstado.Enabled = valor;
                this.cbCargo.Enabled = valor;
            this.txtDescripcion.Enabled = valor;
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
            this.dgvRegistros.DataSource = NUsuario.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dgvRegistros.Rows.Count);
        }
        private void Buscar()
        {
            this.dgvRegistros.DataSource = NUsuario.Buscar(this.txtBuscarNombre.Text, this.dtF1.Text, this.dtF2.Text);
            //this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dgvRegistros.Rows.Count);
        }

        private void cargarCargos()
        {
            cbCargo.DataSource = NCargos.Mostrar();
            cbCargo.ValueMember = "CodigoC";
            cbCargo.DisplayMember = "Cargo";
        }
        private void FrmUsuario_Load(object sender, EventArgs e)
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
            label14.Visible = false;
            l.Visible = false;
            txtDescripcion.Visible = false;
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

            label14.Visible = true;
            l.Visible = true;
            txtDescripcion.Visible = true;
            txtCodigo.Visible = true;
            label10.Visible = true;
        }
        //!this.cbEstado.Text.Equals("")
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
                this.cbCargo.Enabled = false;
                this.txtCodigo.Enabled = false;
                this.txtNombre.Enabled = false;
                this.txtApellidos.Enabled = false;
                this.cbSexo.Enabled = false;
                this.txtUsuario.Enabled = false;
                this.txtPassword.Enabled = false;
                this.txtDireccion.Enabled = false;
                this.txtTelefono.Enabled = false;
                errorIcono.SetError(cbEstado, "Cambie el estado");
               
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (this.txtNombre.Text == string.Empty || this.txtApellidos.Text == string.Empty || this.txtTelefono.Text == string.Empty || this.txtUsuario.Text == string.Empty || this.txtPassword.Text == string.Empty || this.txtCodigoCargo.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(txtNombre, "Ingrese el nombre");
                    errorIcono.SetError(txtApellidos, "Ingrese el apellido");
                    errorIcono.SetError(txtPassword, "Ingrese el password");
                    errorIcono.SetError(txtUsuario, "Ingrese el usuaurio");
                    errorIcono.SetError(txtTelefono, "Ingrese el telefono");
                    errorIcono.SetError(cbSexo, "Ingrese el sexo");
                    errorIcono.SetError(cbCargo, "Ingrese el telefono");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        Rpta = NUsuario.Insertar(Convert.ToInt32(txtCodigoCargo.Text),
                        this.txtNombre.Text,
                        this.txtApellidos.Text,
                        txtDireccion.Text,
                        Convert.ToDateTime(DateTime.Now.ToShortTimeString()),
                        Convert.ToInt32(txtTelefono.Text),
                        cbSexo.Text,
                        "ACTIVO",                     
                        txtUsuario.Text,
                        txtPassword.Text
                        );
                    }
                    else
                    {
                         Rpta = NUsuario.Editar(Convert.ToInt32(txtCodigo.Text),
                         Convert.ToInt32(txtCodigoCargo.Text),
                         this.txtNombre.Text,
                         this.txtApellidos.Text,
                         txtDireccion.Text,
                         Convert.ToInt32(txtTelefono.Text),
                         cbSexo.Text,
                         cbEstado.Text,
                         txtUsuario.Text,
                         txtPassword.Text
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
                    label14.Visible = true;
                    l.Visible = true;
                    txtDescripcion.Visible = true;
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
                this.txtUsuario.Enabled = false;
                this.txtPassword.Enabled = false;

                errorIcono.SetError(txtDireccion, "Ingrese el nombre");
                errorIcono.SetError(txtTelefono, "Ingrese el apellido");
                errorIcono.SetError(cbCargo, "Ingrese el password");
                errorIcono.SetError(cbEstado, "Ingrese el estado");
                label14.Visible = false;
                l.Visible = false;
                txtDescripcion.Visible = false;
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
            this.txtCodigo.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["CodigoU"].Value);
            this.txtNombre.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Nombre"].Value);
            this.txtApellidos.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Apellidos"].Value);
            this.cbSexo.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Sexo"].Value);
            this.txtDireccion.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Direccion"].Value);
            this.txtTelefono.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Telefono"].Value);
            this.cbEstado.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Estado"].Value);
            this.txtUsuario.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Usuario"].Value);
            this.txtPassword.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Password"].Value);
            this.txtDescripcion.Text = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Descripcion"].Value);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololetras(e);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololetras(e);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
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
                        Rpta = NUsuario.Eliminar(Convert.ToInt32(txtCodigo.Text));

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

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCargo.Text == "ADMINISTRADOR")
            {
                txtCodigoCargo.Text = "1";
            }
            else if (cbCargo.Text == "SECRETARIA")
            {
                txtCodigoCargo.Text = "2";
            }
            else if (cbCargo.Text == "VENDEDOR")
            {
                txtCodigoCargo.Text = "4";
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtCodigo.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.txtCodigo.Enabled = false;
                this.txtNombre.Enabled = false;
                this.txtApellidos.Enabled = false;
                this.cbSexo.Enabled = false;
                this.txtUsuario.Enabled = false;
                this.txtPassword.Enabled = false;

                errorIcono.SetError(txtTelefono, "Ingrese el apellido");
                errorIcono.SetError(cbCargo, "Ingrese el password");
                errorIcono.SetError(cbEstado, "Ingrese el estado");
                label14.Visible = false;
                l.Visible = false;
                txtDescripcion.Visible = false;
            }
            else
            {
                this.MensajeError("Debe de seleccionar primero el registro a Modificar");
            }
        }
    }
}
