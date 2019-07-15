using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class DDetalleReserva
    {
        private int _Codigo;
        private int _Reserva;
        private int _Lotes;
        private string _Precio_Unitario;

        public int Codigo { get => _Codigo; set => _Codigo = value; }
        public int Reserva { get => _Reserva; set => _Reserva = value; }
        public int Lotes { get => _Lotes; set => _Lotes = value; }
        public string Precio_Unitario { get => _Precio_Unitario; set => _Precio_Unitario = value; }

        public DDetalleReserva()
        { }

        public DDetalleReserva(int codigo, int reserva, int lotes, string precio_total)
        {
            this.Codigo = codigo;
            this.Reserva = reserva;
            this.Lotes = lotes;
            this.Precio_Unitario = precio_total;
        }
        public string Insertar1(DDetalleReserva Detalle,
           ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string rpta = "";
            try
            {
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spinsertar_detalle";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCodigoCargo = new SqlParameter();
                ParCodigoCargo.ParameterName = "@codigo";
                ParCodigoCargo.SqlDbType = SqlDbType.Int;
                //ParIdPedidos.Value = Solicitud.Codigo;
                ParCodigoCargo.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParCodigoCargo);

                SqlParameter ParReserva = new SqlParameter();
                ParReserva.ParameterName = "@reserva";
                ParReserva.SqlDbType = SqlDbType.Int;
                ParReserva.Value = Detalle.Reserva;
                SqlCmd.Parameters.Add(ParReserva);

                SqlParameter ParLotes = new SqlParameter();
                ParLotes.ParameterName = "@lote";
                ParLotes.SqlDbType = SqlDbType.Int;
                ParLotes.Value = Detalle.Lotes;
                SqlCmd.Parameters.Add(ParLotes);


                SqlParameter ParPrecio_Total = new SqlParameter();
                ParPrecio_Total.ParameterName = "@precio_Unitario";
                ParPrecio_Total.SqlDbType = SqlDbType.VarChar;
                ParPrecio_Total.Size = 100;
                ParPrecio_Total.Value = Detalle.Precio_Unitario;
                SqlCmd.Parameters.Add(ParPrecio_Total);



                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            return rpta;

        }


        public string Insertar(DDetalleReserva Detalle,
           ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string rpta = "";
            try
            {

                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_detalle";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCodigoCargo = new SqlParameter();
                ParCodigoCargo.ParameterName = "@codigo";
                ParCodigoCargo.SqlDbType = SqlDbType.Int;
                //ParIdPedidos.Value = Solicitud.Codigo;
                ParCodigoCargo.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParCodigoCargo);

                SqlParameter ParReserva = new SqlParameter();
                ParReserva.ParameterName = "@reserva";
                ParReserva.SqlDbType = SqlDbType.Int;
                ParReserva.Value = Detalle.Reserva;
                SqlCmd.Parameters.Add(ParReserva);

                SqlParameter ParLotes = new SqlParameter();
                ParLotes.ParameterName = "@lote";
                ParLotes.SqlDbType = SqlDbType.Int;
                ParLotes.Value = Detalle.Lotes;
                SqlCmd.Parameters.Add(ParLotes);


                SqlParameter ParPrecio_Total = new SqlParameter();
                ParPrecio_Total.ParameterName = "@precio_Unitario";
                ParPrecio_Total.SqlDbType = SqlDbType.VarChar;
                ParPrecio_Total.Size = 100;
                ParPrecio_Total.Value = Detalle.Precio_Unitario;
                SqlCmd.Parameters.Add(ParPrecio_Total);


                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }


        public string Editar(DDetalleReserva Detalle,
         ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string rpta = "";
            try
            {

                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_reserva";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCodigoCargo = new SqlParameter();
                ParCodigoCargo.ParameterName = "@codigo";
                ParCodigoCargo.SqlDbType = SqlDbType.Int;
                ParCodigoCargo.Value = Detalle.Codigo;
                //ParCodigoCargo.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParCodigoCargo);

                SqlParameter ParReserva = new SqlParameter();
                ParReserva.ParameterName = "@reserva";
                ParReserva.SqlDbType = SqlDbType.Int;
                ParReserva.Value = Detalle.Reserva;
                SqlCmd.Parameters.Add(ParReserva);

                SqlParameter ParLotes = new SqlParameter();
                ParLotes.ParameterName = "@lote";
                ParLotes.SqlDbType = SqlDbType.Int;
                ParLotes.Value = Detalle.Lotes;
                SqlCmd.Parameters.Add(ParLotes);


                SqlParameter ParPrecio_Total = new SqlParameter();
                ParPrecio_Total.ParameterName = "@precio_Unitario";
                ParPrecio_Total.SqlDbType = SqlDbType.VarChar;
                ParPrecio_Total.Size = 100;
                ParPrecio_Total.Value = Detalle.Precio_Unitario;
                SqlCmd.Parameters.Add(ParPrecio_Total);


                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

    }
}
