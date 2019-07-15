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
    public partial class FrmVistaCliente : Form
    {
        public FrmVistaCliente()
        {
            InitializeComponent();
        }
        private void OcultarColumnas()
        {
            this.dgvRegistros.Columns[0].Visible = false;
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
        private void FrmVistaCliente_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void TxtBuscarNombre_TextChanged(object sender, EventArgs e)
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

        private void TxtBuscarSexo_SelectedIndexChanged(object sender, EventArgs e)
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

        private void TxtBuscarCI_TextChanged(object sender, EventArgs e)
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

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            this.Mostrar();
            this.txtBuscarSexo.Text = string.Empty;
        }

        private void DgvRegistros_DoubleClick(object sender, EventArgs e)
        {
            FrmReservas form = FrmReservas.GetInstancia();
            string par1;
            string par2;
            par1 = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["CodigoCL"].Value);
            par2 = Convert.ToString(this.dgvRegistros.CurrentRow.Cells["Nombres"].Value);
            form.setCliente(par1, par2);
            this.Hide();
        }
    }
}
