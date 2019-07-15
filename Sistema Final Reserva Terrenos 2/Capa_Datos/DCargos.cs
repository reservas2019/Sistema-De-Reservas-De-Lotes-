using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
   public class DCargos
    {
        private int _CodigoC;
        private string _Cargo;
        private DateTime _Fecha_Registro;
        private string _Estado;
        private string _Descripcion;

        public int CodigoC
        {
            get
            {
                return _CodigoC;
            }

            set
            {
                _CodigoC = value;
            }
        }

        public string Cargo
        {
            get
            {
                return _Cargo;
            }

            set
            {
                _Cargo = value;
            }
        }

        public DateTime Fecha_Registro
        {
            get
            {
                return _Fecha_Registro;
            }

            set
            {
                _Fecha_Registro = value;
            }
        }

        public string Estado
        {
            get
            {
                return _Estado;
            }

            set
            {
                _Estado = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }

            set
            {
                _Descripcion = value;
            }
        }

        public DCargos()
        { }

        public DCargos(int codigo , string cargo, DateTime fecha_registro, string estado, string descripcion)
        {
            this.CodigoC = codigo;
            this.Cargo = cargo;
            this.Fecha_Registro = fecha_registro;
            this.Estado = estado;
            this.Descripcion = descripcion;
        }
        public string Insertar(DCargos Cargo)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {

                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
             
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_cargo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCodigoCargo = new SqlParameter();
                ParCodigoCargo.ParameterName = "@codigoC";
                ParCodigoCargo.SqlDbType = SqlDbType.Int;
                //ParIdPedidos.Value = Solicitud.Codigo;
                ParCodigoCargo.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParCodigoCargo);

                SqlParameter ParCargo = new SqlParameter();
                ParCargo.ParameterName = "@cargo";
                ParCargo.SqlDbType = SqlDbType.VarChar;
                ParCargo.Size = 50;
                ParCargo.Value = Cargo.Cargo;
                SqlCmd.Parameters.Add(ParCargo);               

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha_registro";
                ParFecha.SqlDbType = SqlDbType.DateTime;
                ParFecha.Value = Cargo.Fecha_Registro;
                SqlCmd.Parameters.Add(ParFecha);               

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 20;
                ParEstado.Value = Cargo.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 100;
                ParDescripcion.Value = Cargo.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                
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

        public string Editar(DCargos Cargo)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {

                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_cargo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@codigoC";
                ParCodigo.SqlDbType = SqlDbType.Int;
                ParCodigo.Value = Cargo.CodigoC;
                //ParIdPedidos.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParCodigo);               

                SqlParameter ParCargo = new SqlParameter();
                ParCargo.ParameterName = "@cargo";
                ParCargo.SqlDbType = SqlDbType.VarChar;
                ParCargo.Size = 50;
                ParCargo.Value = Cargo.Cargo;
                SqlCmd.Parameters.Add(ParCargo);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 20;
                ParEstado.Value = Cargo.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 100;
                ParDescripcion.Value = Cargo.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Actualizo el Registro";
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

        public DataTable Buscar(String Cargo, String Estado)
        {
            DataTable DtResultado = new DataTable("Usuario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_cargo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParBnOMBRE = new SqlParameter();
                ParBnOMBRE.ParameterName = "@cargo";
                ParBnOMBRE.SqlDbType = SqlDbType.VarChar;
                ParBnOMBRE.Size = 50;
                ParBnOMBRE.Value = Cargo;
                SqlCmd.Parameters.Add(ParBnOMBRE);

                SqlParameter ParF1 = new SqlParameter();
                ParF1.ParameterName = "@estado";
                ParF1.SqlDbType = SqlDbType.VarChar;
                ParF1.Size = 50;
                ParF1.Value = Estado;
                SqlCmd.Parameters.Add(ParF1);

             

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {

                DtResultado = null;
            }

            return DtResultado;
        }

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("cargo");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_cargo";
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

        public string Elminar(DCargos Cargo)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {

                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_cargo";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter Parnombre = new SqlParameter();
                Parnombre.ParameterName = "@codigo";
                Parnombre.SqlDbType = SqlDbType.Int;
                //Parnombre.Size = 50;
                Parnombre.Value = Cargo.CodigoC;
                SqlCmd.Parameters.Add(Parnombre);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Elimino el Registro";
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
