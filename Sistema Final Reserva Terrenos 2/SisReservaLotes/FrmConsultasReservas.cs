using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SisReservaLotes
{
    public partial class FrmConsultasReservas : Form
    {
        public FrmConsultasReservas()
        {
            InitializeComponent();
        }
        private void Lote1()
        {
            SqlConnection connect = new SqlConnection("Server=.;database=SisReserva;integrated security=true");
            SqlCommand command = new SqlCommand("select Imagen from Lotes where CodigoL = 1", connect);
            SqlDataAdapter dp = new SqlDataAdapter(command);
            DataSet ds = new DataSet("Lotes");
            byte[] MisDatos = new byte[0];
            dp.Fill(ds, "Lotes");
            DataRow myRow = ds.Tables["Lotes"].Rows[0];
            MisDatos = (byte[])myRow["Imagen"];

            System.IO.MemoryStream ms = new System.IO.MemoryStream(MisDatos);
            px1.Image = Image.FromStream(ms);
            this.px1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void Lote2()
        {
            SqlConnection connect = new SqlConnection("Server=.;database=SisReserva;integrated security=true");
            SqlCommand command = new SqlCommand("select Imagen from Lotes where CodigoL = 2", connect);
            SqlDataAdapter dp = new SqlDataAdapter(command);
            DataSet ds = new DataSet("Lotes");
            byte[] MisDatos = new byte[0];
            dp.Fill(ds, "Lotes");
            DataRow myRow = ds.Tables["Lotes"].Rows[0];
            MisDatos = (byte[])myRow["Imagen"];

            System.IO.MemoryStream ms = new System.IO.MemoryStream(MisDatos);
            px2.Image = Image.FromStream(ms);
            this.px2.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
        

        }

        private void FrmConsultasReservas_Load(object sender, EventArgs e)
        {
            this.Lote1();
            this.Lote2();
        }
    }
}
