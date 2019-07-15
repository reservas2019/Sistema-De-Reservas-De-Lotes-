using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
   public class DReserva
    {
        private int _Codigo;
        private int _Cliente;
        private int _Usuario;
        private int _Cantidad;
        private string _Estado;
        private DateTime _Fecha_registro;
        private DateTime _Fecha_Limite;
        private string _Precio_Total;

        public int Codigo { get => _Codigo; set => _Codigo = value; }
        public int Cliente { get => _Cliente; set => _Cliente = value; }
        public int Usuario { get => _Usuario; set => _Usuario = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public DateTime Fecha_registro { get => _Fecha_registro; set => _Fecha_registro = value; }
        public DateTime Fecha_Limite { get => _Fecha_Limite; set => _Fecha_Limite = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string Precio_Total { get => _Precio_Total; set => _Precio_Total = value; }

        public DReserva()
        { }

        public DReserva(int codigo, int cliente, int usuario, int cantidad,string estado, DateTime fecha_registro, DateTime fecha_limite, string precio_total)
        {
            this.Codigo = codigo;
            this.Cliente = cliente;
            this.Usuario = usuario;
            this.Cantidad = cantidad;
            this.Estado = estado;
            this.Fecha_registro = fecha_registro;
            this.Fecha_Limite = fecha_limite;
            this.Precio_Total = precio_total;
        }

        public string Insertar(DReserva Reserva, List<DDetalleReserva> Detalle)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {

                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlTransaction SqlTra = SqlCon.BeginTransaction();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spinsertar_reserva";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParValor = new SqlParameter();
                ParValor.ParameterName = "@codigo";
                ParValor.SqlDbType = SqlDbType.Int;
                //ParIdPedidos.Value = Solicitud.Codigo;
                ParValor.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParValor);

                SqlParameter ParCliente = new SqlParameter();
                ParCliente.ParameterName = "@cliente";
                ParCliente.SqlDbType = SqlDbType.Int;
                ParCliente.Value = Reserva.Cliente;
                SqlCmd.Parameters.Add(ParCliente);

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@usuario";
                ParUsuario.SqlDbType = SqlDbType.Int;
                ParUsuario.Value = Reserva.Usuario;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@cantidad";
                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.Value = Reserva.Cantidad;
                SqlCmd.Parameters.Add(ParCantidad);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 20;
                ParEstado.Value = Reserva.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParFechRegistro = new SqlParameter();
                ParFechRegistro.ParameterName = "@fecha_registro";
                ParFechRegistro.SqlDbType = SqlDbType.DateTime;
                ParFechRegistro.Value = Reserva.Fecha_registro;
                SqlCmd.Parameters.Add(ParFechRegistro);

                SqlParameter ParFechaLimite = new SqlParameter();
                ParFechaLimite.ParameterName = "@fecha_limite";
                ParFechaLimite.SqlDbType = SqlDbType.DateTime;
                ParFechaLimite.Value = Reserva.Fecha_Limite;
                SqlCmd.Parameters.Add(ParFechaLimite);

                SqlParameter ParPrecioTotal = new SqlParameter();
                ParPrecioTotal.ParameterName = "@precio_total";
                ParPrecioTotal.SqlDbType = SqlDbType.VarChar;
                ParPrecioTotal.Size = 100;
                ParPrecioTotal.Value = Reserva.Precio_Total;
                SqlCmd.Parameters.Add(ParPrecioTotal);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro Reserva";

                if (rpta.Equals("OK"))
                {

                    this.Codigo = Convert.ToInt32(SqlCmd.Parameters["@codigo"].Value);
                    foreach (DDetalleReserva det in Detalle)
                    {
                        det.Reserva = this.Codigo;

                        rpta = det.Insertar1(det, ref SqlCon, ref SqlTra);
                        if (!rpta.Equals("OK"))
                        {
                            break;
                        }
                    }

                }
                if (rpta.Equals("OK"))
                {
                    SqlTra.Commit();
                }
                else
                {
                    SqlTra.Rollback();
                }


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

        public string Editar(DReserva Reserva, List<DDetalleReserva> Detalle)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {

                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlTransaction SqlTra = SqlCon.BeginTransaction();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "speditar_reserva";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParValor = new SqlParameter();
                ParValor.ParameterName = "@codigo";
                ParValor.SqlDbType = SqlDbType.Int;
                ParValor.Value = Reserva.Codigo;
                //ParValor.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParValor);

                SqlParameter ParCliente = new SqlParameter();
                ParCliente.ParameterName = "@cliente";
                ParCliente.SqlDbType = SqlDbType.Int;
                ParCliente.Value = Reserva.Cliente;
                SqlCmd.Parameters.Add(ParCliente);

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@usuario";
                ParUsuario.SqlDbType = SqlDbType.Int;
                ParUsuario.Value = Reserva.Usuario;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@cantidad";
                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.Value = Reserva.Cantidad;
                SqlCmd.Parameters.Add(ParCantidad);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 20;
                ParEstado.Value = Reserva.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParPrecioTotal = new SqlParameter();
                ParPrecioTotal.ParameterName = "@precio_total";
                ParPrecioTotal.SqlDbType = SqlDbType.VarChar;
                ParPrecioTotal.Size = 100;
                ParPrecioTotal.Value = Reserva.Precio_Total;
                SqlCmd.Parameters.Add(ParPrecioTotal);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro Reserva";

                if (rpta.Equals("OK"))
                {

                    this.Codigo = Convert.ToInt32(SqlCmd.Parameters["@codigo"].Value);
                    foreach (DDetalleReserva det in Detalle)
                    {
                        det.Reserva = this.Codigo;

                        rpta = det.Insertar1(det, ref SqlCon, ref SqlTra);
                        if (!rpta.Equals("OK"))
                        {
                            break;
                        }
                    }

                }
                if (rpta.Equals("OK"))
                {
                    SqlTra.Commit();
                }
                else
                {
                    SqlTra.Rollback();
                }


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

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("reserva");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostar_reserva";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public DataTable Buscar(String Nombre, String Estado, String TextoBuscar, String TextoBuscar2)
        {
            DataTable DtResultado = new DataTable("Reserva");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_reserva";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 20;
                ParEstado.Value = Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@fecha1";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscar2 = new SqlParameter();
                ParTextoBuscar2.ParameterName = "@fecha2";
                ParTextoBuscar2.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar2.Size = 50;
                ParTextoBuscar2.Value = TextoBuscar2;
                SqlCmd.Parameters.Add(ParTextoBuscar2);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

        public string Eliminar(DReserva Reserva)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spelimianar_reserva";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@codigo";
                ParCodigo.SqlDbType = SqlDbType.Int;
                ParCodigo.Value = Reserva.Codigo;
                SqlCmd.Parameters.Add(ParCodigo);

                if (SqlCmd.ExecuteNonQuery() == 1) //? "OK" : "NO se Elimino el Registro";
                {
                    rpta = "OK";
                }
                else
                    rpta = "NO se Elimino el Registro";
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

        public DataTable MostrarDetalle(String TextoBuscar)
        {
            DataTable DtResultado = new DataTable("maestro_detalle");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_detalle";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@codigo";
                ParTextoBuscar.SqlDbType = SqlDbType.Int;
                //ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }
    }
}
