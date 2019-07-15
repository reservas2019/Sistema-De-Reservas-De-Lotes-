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
    public partial class FrmReservas : Form
    {
        public int IdFuncionario;
        private bool IsNuevo;
        private bool IsEditar;
        private DataTable dtDetalle;

        private static FrmReservas _instancia;

        public static FrmReservas GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new FrmReservas();
            }
            return _instancia;
        }
        public void setCliente(string codigo, string nombre)
        {
            this.txtCodigoCliente.Text = codigo;
            this.txtNombreCliente.Text = nombre;
        }
        public void setLotes(string codigo, string nombre, string precio_unitario)
        {
            this.txtCodigoLote.Text = codigo;
            this.txtLote.Text = nombre;
            this.txtPrecioUnitario.Text = precio_unitario;
        }
        public FrmReservas()
        {
            InitializeComponent();
            //this.txtCodigoLote.Visible = false;
            this.txtCodigoCliente.Visible = false;
            this.txtCodigoDetalle.Visible = false;
            lbhora.Text = DateTime.Now.ToString();
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Reservas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void cargar()
        {
            if (this.txtcodigoReserva.Text == String.Empty || txtcodigoReserva.Text == "")
            {

                dataListadoDetalle.DataSource = null;
            }
            else
            {
                if (dataListadoDetalle.Rows.Count > 0)
                {
                    this.cargarDetalle();

                }
                else
                {

                }
            }
        }
        private void crearTabla()
        {
            this.dtDetalle = new DataTable("Detalle");
            this.dtDetalle.Columns.Add("CodigoL", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Lote", System.Type.GetType("System.Int32"));


            //this.dtDetalle.Columns.Add("Superficie", System.Type.GetType("System.String"));
            //this.dtDetalle.Columns.Add("Nro_Lote", System.Type.GetType("System.String"));
            //this.dtDetalle.Columns.Add("Descripcion", System.Type.GetType("System.Int32"));
            //this.dtDetalle.Columns.Add("Sector", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Cantidad", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Precio_Unitario", System.Type.GetType("System.String"));
            //this.dtDetalle.Columns.Add("Precio_Unitario", System.Type.GetType("System.Int32"));
            //this.dtDetalle.Columns.Add("fchreg", System.Type.GetType("System.DateTime"));


            this.dataListadoDetalle.DataSource = this.dtDetalle;

        }
        private void Limpiar()
        {
            txtCodigoCliente.Text = string.Empty;
            txtcodigoReserva.Text = string.Empty;
            this.txtNombreCliente.Text = string.Empty;
            this.txtLote.Text = string.Empty;
            this.txtCodigoLote.Text = string.Empty;
            this.txtPrecioTotal.Text = string.Empty;
            this.txtPrecioUnitario.Text = string.Empty;
            this.crearTabla();
        }
        private void LimpiarDetalle()
        {
            this.txtLote.Text = string.Empty;
            this.txtCodigoLote.Text = string.Empty;
            this.txtCantidad.Text = string.Empty;
            this.txtPrecioTotal.Text = string.Empty;
            this.txtPrecioUnitario.Text = string.Empty;
            this.crearTabla();
        }

        private void Habilitar(bool valor)
        {
            this.txtNombreCliente.Enabled = valor;
            this.txtCodigoCliente.Enabled = valor;
            this.CbEstado.Enabled = valor;
            this.btnAgregar.Enabled = valor;
            this.btnQuitar.Enabled = valor;
            this.btnBuscarCliente.Enabled = valor;
            this.btnBuscarLotes.Enabled = valor;
        }
        private void HabilitarDetalle(bool valor)
        {
            this.txtLote.Enabled = valor;
            this.txtCantidad.Enabled = valor;
            this.txtPrecioUnitario.Enabled = valor;
            this.txtPrecioTotal.Enabled = valor;
            this.dtfechaRegistro.Enabled = valor;
            this.dtFechaLimite.Enabled = valor;
            this.btnBuscarCliente.Enabled = valor;
            this.btnBuscarLotes.Enabled = valor;
        }
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                this.Habilitar(true);
                this.HabilitarDetalle(true);
                this.btnNuevo.Enabled = false;
                this.btnCancelar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnG.Enabled = true;
                this.btnAgregar.Enabled = true;
                this.btnQuitar.Enabled = true;
                this.btnElim.Enabled = false;

            }
            else
            {
                this.Habilitar(false);
                this.HabilitarDetalle(false);
                this.btnNuevo.Enabled = true;
                //this.btnconsultar.Enabled = false;
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnG.Enabled = false;
                this.btnAgregar.Enabled = false;
                this.btnQuitar.Enabled = false;
                this.btnElim.Enabled = true;
            }

        }
        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
            this.dataListado.Columns[2].Visible = false;
            this.dataListado.Columns[3].Visible = false;
        }
        private void OcultarColumnasDetalle()
        {
            this.dataListadoDetalle.Columns[0].Visible = false;
            //this.dataListadoDetalle.Columns[1].Visible = false;
            //this.dataListadoDetalle.Columns[2].Visible = false;
        }
        private void Buscar()
        {
            this.dataListado.DataSource = NReserva.Buscar(this.txtNombreBuscar.Text, cbBuscarEstado.Text, this.dtFecha1.Text,
                this.dtFecha2.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void cargarReserva()
        {
            this.txtcodigoReserva.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["CodigoR"].Value);
            this.txtCodigoCliente.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["CodigoCL"].Value);
            this.txtNombreCliente.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Cliente"].Value);
            this.txtcodigoReserva.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["CodigoR"].Value);
            this.CbEstado.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Estado"].Value);
            this.dtfechaRegistro.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Fecha_Registro"].Value);
            this.dtFechaLimite.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Fecha_Limite"].Value);
            this.txtPrecioTotal.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Precio_Total"].Value);
            this.MostrarDetalle();
        }
        private void cargarDetalle()
        {
            this.txtPrecioUnitario.Text = Convert.ToString(this.dataListadoDetalle.CurrentRow.Cells["Precio_Unitario"].Value);
            //this.txtCodigoDetalle.Text = Convert.ToString(this.dataListadoDetalle.CurrentRow.Cells["CodigoDTLL"].Value);
            this.txtCodigoLote.Text = Convert.ToString(this.dataListadoDetalle.CurrentRow.Cells["CodigoL"].Value);
            this.txtCantidad.Text = Convert.ToString(this.dataListadoDetalle.CurrentRow.Cells["Cantidad"].Value);
            this.txtCodigoLote.Text = Convert.ToString(this.dataListadoDetalle.CurrentRow.Cells["CodigoL"].Value);
            this.txtLote.Text = Convert.ToString(this.dataListadoDetalle.CurrentRow.Cells["Lote"].Value);
        }
        private void Mostrar()
        {
            this.dataListado.DataSource = NReserva.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void MostrarDetalle()
        {
            this.dataListadoDetalle.DataSource = NReserva.MostrarDetalle(this.txtcodigoReserva.Text);
            this.OcultarColumnasDetalle();
            lbregistrosdetalle.Text = "Total de Registros: " + Convert.ToString(dataListadoDetalle.Rows.Count);
        }
        private void FrmReservas_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            //this.HabDetalle();
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.MostrarDetalle();
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
            this.HabilitarDetalle(false);
            this.crearTabla();
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmVistaCliente frm = new FrmVistaCliente();
            frm.ShowDialog();
        }

        private void BtnBuscarLotes_Click(object sender, EventArgs e)
        {
            FrmVistaLotes frm = new FrmVistaLotes();
            frm.ShowDialog();
        }

        private void TxtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecioUnitario.Text != string.Empty && txtCantidad.Text != string.Empty)
            {

                double a, b, total;
                a = double.Parse(txtCantidad.Text);
                b = double.Parse(txtPrecioUnitario.Text);
                total = a * b;
                txtPrecioTotal.Text = total.ToString();
            }
            else if (txtCantidad.Text == string.Empty)
            {
                txtPrecioTotal.Text = string.Empty;
            }
        }

        private void TxtPrecioTotal_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecioUnitario.Text != string.Empty && txtCantidad.Text != string.Empty)
            {

                double a, b, total;
                a = double.Parse(txtCantidad.Text);
                b = double.Parse(txtPrecioUnitario.Text);
                total = a * b;
                txtPrecioTotal.Text = total.ToString();
            }
            else if (txtCantidad.Text == string.Empty)
            {
                txtPrecioTotal.Text = string.Empty;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtCodigoCliente.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(txtNombreCliente, "Ingrese un Valor");
                    errorIcono.SetError(txtCantidad, "Ingrese un Valor");

                }
                else
                {

                    if (this.IsNuevo)
                    {
                        rpta = NReserva.Insertar(Convert.ToInt32(this.txtCodigoCliente.Text), 7,Convert.ToInt32( txtCantidad.Text),"RESERVADO",
                              Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")), dtFechaLimite.Value,txtPrecioTotal.Text, dtDetalle);
                    }
                    else
                    {
                      

                    }

                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se Insertó de forma correcta el registro");

                            this.dataListado.Enabled = true;
                            this.dataListadoDetalle.Enabled = false;
                            this.groupBox1.Enabled = false;
                            this.groupBox2.Enabled = false;
                            errorIcono.Clear();

                        }
                        else
                        {
                            this.MensajeOk("se actualizo de forma correcta el registro");

                            this.groupBox1.Enabled = false;
                            this.groupBox2.Enabled = false;
                            this.dataListado.Enabled = true;
                            this.dataListadoDetalle.Enabled = false;
                            errorIcono.Clear();
                        }

                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }

                    this.IsNuevo = false;
                    this.IsEditar = false;
                    //this.Botones();
                    //this.Limpiar();
                    //this.limpiarDetalle();
                    //this.Mostrar();
                    //this.MostrarDetalle();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            NLotes.CambiarEstado(Convert.ToInt32(txtCodigoLote.Text));
            try

            {

                if ( this.txtCantidad.Text == string.Empty
                   )
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    //errorIcono.SetError(txtDetalle, "Ingrese un Valor");
                    //errorIcono.SetError(txtCantidad, "Ingrese un Valor");

 
                }
                else
                {
                    bool registrar = true;
                    foreach (DataRow row in dtDetalle.Rows)
                    {
                        if (Convert.ToInt32(row["Lote"]) == Convert.ToInt32(this.txtCodigoLote.Text))
                        {
                            registrar = false;
                            this.MensajeError("YA se encuentra este Lote en el detalle");
                        }

                    }
                    if (registrar)
                    {

                        DataRow row = this.dtDetalle.NewRow();
                        row["CodigoL"] = Convert.ToInt32(this.txtCodigoLote.Text);
                        row["Lote"] = Convert.ToInt32(this.txtLote.Text);
                        row["Cantidad"] = Convert.ToInt32(this.txtCantidad.Text);
                        row["Precio_Unitario"] = this.txtPrecioUnitario.Text;



                        this.dtDetalle.Rows.Add(row);

                    }
                    //else
                    //{

                    //    DataRow row = this.dtDetalle.NewRow();
                    //    row["idarticulo"] = Convert.ToInt32(this.txtIdArticulo.Text);
                    //    row["nombre_articulo"] = this.txtNombreArticulo.Text;

                    //    row["descripcion"] = this.txtDescripcion.Text;
                    //    row["cantidad"] = Convert.ToInt32(this.txtCantidad.Text);
                    //    row["precio_unitario"] = Convert.ToDecimal(this.txtPrecioUnaitario.Text);
                    //    row["precio_sub_total"] = Convert.ToDecimal(this.txtPrecioTotal.Text);
                    //    //row["subtotal"] = subTotal;
                    //    this.dtDetalle.Rows.Add(row);
                    //    this.limpiarDetalle();
                    //    this.sumar();
                    //}



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TxtPrecioTotal_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.HabilitarDetalle(true);
            this.txtNombreCliente.Focus();
            //limpiarDetalle();
        }

        private void BtnG_Click(object sender, EventArgs e)
        {
           
            try
            {
                string rpta = "";
                if (this.txtCodigoCliente.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorIcono.SetError(txtNombreCliente, "Ingrese un Valor");
                    errorIcono.SetError(txtCantidad, "Ingrese un Valor");

                }
                else
                {

                    if (this.IsNuevo)
                    {
                        rpta = NReserva.Insertar(Convert.ToInt32(this.txtCodigoCliente.Text), 9, Convert.ToInt32(txtCantidad.Text),"RESERVADO",
                              Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")), dtFechaLimite.Value, txtPrecioTotal.Text, dtDetalle);

                    }
                    else
                    {
                        rpta = NReserva.Editar(Convert.ToInt32(txtcodigoReserva.Text),
                            Convert.ToInt32(this.txtCodigoCliente.Text),
                            9,
                            Convert.ToInt32(txtCantidad.Text),
                            CbEstado.Text,
                            txtPrecioTotal.Text,
                            dtDetalle);

                    }

                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se Insertó de forma correcta el registro");

                            errorIcono.Clear();

                        }
                        else
                        {
                            this.MensajeOk("se actualizo de forma correcta el registro");
                            errorIcono.Clear();
                        }

                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }

                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    //this.limpiarDetalle();
                    this.Mostrar();
                    this.MostrarDetalle();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void DataListado_Click(object sender, EventArgs e)
        {
            if (dataListado.Rows.Count == 0)
            {
                this.dataListado.Enabled = false;
            }
            else
            {
                cargar();
                this.cargarReserva();
                this.MostrarDetalle();
            }
        }
        private void HabDetalle()
        {
            if (dataListado.Rows.Count == 0)
            {

                this.dataListadoDetalle.Enabled = false;
            }

            else if (dataListado.Rows.Count >= 1)
            {
                this.dataListadoDetalle.Enabled = true;
                this.cargarDetalle();
            }
            else
            {
                
            }
        }
        private void DataListadoDetalle_Click(object sender, EventArgs e)
        {
          
                this.cargarDetalle();
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
            this.HabilitarDetalle(false);
        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void EditarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtcodigoReserva.Text == string.Empty)
            {
                MensajeError("Seleccione un registro");
            }
            else
            {
                this.groupBox1.Enabled = false;
                this.groupBox2.Enabled = true;
                this.IsEditar = true;
                this.Botones();
                this.crearTabla();
                //this.Limpiar();
                //Habilitar(false);
                HabilitarDetalle(true);
                errorIcono.SetError(txtCantidad, "actualize la nueva Cantidad");
                btnG.Visible = true;
                btnGuardar.Visible = false;
            }
        }

        private void BtnElim_Click(object sender, EventArgs e)
        {
            if (CbEstado.Text == "RESERVADO")
            {
                MensajeError("No se pueden eliminar reservas con estados Reservado");
            }
            
            else
            {
                try
                {
                    DialogResult Opcion;
                    Opcion = MessageBox.Show("Realmente Desea Eliminar los Registros", "Sistema de Reserva", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (Opcion == DialogResult.OK)
                    {

                        string Rpta = "";

                        Rpta = NReserva.Eliminar(Convert.ToInt32(txtcodigoReserva.Text));

                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se Eliminó Correctamente esta Reserva");
                        }
                        else
                        {
                            this.MensajeError("Error no puede eliminar esta Reserva");
                        }


                        this.Mostrar();
                        this.MostrarDetalle();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void TxtNombreBuscar_TextChanged(object sender, EventArgs e)
        {
            if (this.txtNombreBuscar.Text == string.Empty)
            {
                this.Mostrar();
            }
            else
            {
                this.Buscar();
            }
        }

        private void CbBuscarBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbBuscarEstado.Text == string.Empty)
            {
                this.Mostrar();
            }
            else
            {
                this.Buscar();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            NLotes.CambiarEstado2(Convert.ToInt32(txtCodigoLote.Text));
            try
            {
                int indiceFila = this.dataListadoDetalle.CurrentCell.RowIndex;
                DataRow row = this.dtDetalle.Rows[indiceFila];

                this.dtDetalle.Rows.Remove(row);
            }
            catch (Exception ex)
            {
                MensajeError("No hay fila para remover");
            }
        }

        private void BtnSumar_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString();

            double total = 0;
            foreach (DataGridViewRow row in dataListadoDetalle.Rows)
            {
                total += Convert.ToDouble(row.Cells["Precio_Unitario"].Value);
            }
            txtPrecioTotal.Text = Convert.ToString(total);
            ldtotal.Text = Convert.ToString(total);
        }

        private void BtnSumar_Click_1(object sender, EventArgs e)
        {
            double total = 0;
            foreach (DataGridViewRow row in dataListadoDetalle.Rows)
            {
                total += Convert.ToDouble(row.Cells["Precio_Unitario"].Value);
            }
            txtPrecioTotal.Text = Convert.ToString(total);
            ldtotal.Text = Convert.ToString(total);
        }
    }
}
