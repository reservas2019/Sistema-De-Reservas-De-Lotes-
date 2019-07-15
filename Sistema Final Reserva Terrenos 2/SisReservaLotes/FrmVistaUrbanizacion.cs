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
    public partial class FrmVistaUrbanizacion : Form
    {
        public FrmVistaUrbanizacion()
        {
            InitializeComponent();
        }
        private void OcultarColumnas()
        {
            this.dgvRegistros.Columns[0].Visible = false;
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
        private void FrmVistaUrbanizacion_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void dgvRegistros_DoubleClick(object sender, EventArgs e)
        {
            FrmLotes form = FrmLotes.GetInstancia();
            string par1;
            string par2;
            par1 = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["CodigoUR"].Value);
            par2 = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Nombre"].Value);
            form.setUrbanizacion(par1, par2);
            this.Hide();
        }
    }
}
