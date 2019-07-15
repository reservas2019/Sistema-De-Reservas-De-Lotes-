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
    public partial class FrmVistaLotes : Form
    {
        public FrmVistaLotes()
        {
            InitializeComponent();
        }
        private void OcultarColumnas()
        {
            this.dgvRegistros.Columns[0].Visible = false;
            this.dgvRegistros.Columns[1].Visible = false;
        }
        private void Mostrar()
        {
            this.dgvRegistros.DataSource = NLotes.MostrarVistas();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dgvRegistros.Rows.Count);
        }
        private void Buscar()
        {
            this.dgvRegistros.DataSource = NLotes.Buscar(this.cbBuscarEstado.Text, this.txtBuscarNro.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dgvRegistros.Rows.Count);
        }
        private void FrmVistaLotes_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void TxtBuscarNro_TextChanged(object sender, EventArgs e)
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

        private void CbBuscarEstado_SelectedIndexChanged(object sender, EventArgs e)
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

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void DgvRegistros_DoubleClick(object sender, EventArgs e)
        {
            FrmReservas form = FrmReservas.GetInstancia();
            string par1;
            string par2;
            string par3;
            par1 = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["CodigoL"].Value);
            par2 = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Nro_Lote"].Value);
            par3 = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Precio"].Value);
            form.setLotes(par1, par2, par3);
            this.Hide();
        }
    }
}
