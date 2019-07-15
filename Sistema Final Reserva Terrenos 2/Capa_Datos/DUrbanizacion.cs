using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
   public class DUrbanizacion
    {
        private int _Codigo_U;
        private string _Nombre;
        private string _Direccion;
        private string _Ciudad;
        private string _Superficie;
        private byte[] _Imagen;

        public int Codigo_U
        {
            get
            {
                return _Codigo_U;
            }

            set
            {
                _Codigo_U = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _Nombre;
            }

            set
            {
                _Nombre = value;
            }
        }

        public string Direccion
        {
            get
            {
                return _Direccion;
            }

            set
            {
                _Direccion = value;
            }
        }

        public string Ciudad
        {
            get
            {
                return _Ciudad;
            }

            set
            {
                _Ciudad = value;
            }
        }

        public string Superficie
        {
            get
            {
                return _Superficie;
            }

            set
            {
                _Superficie = value;
            }
        }

        public byte[] Imagen { get => _Imagen; set => _Imagen = value; }

        public string Insertar(DUrbanizacion Urbanizacion)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {

                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_urbanizacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdPedidos = new SqlParameter();
                ParIdPedidos.ParameterName = "@codigou";
                ParIdPedidos.SqlDbType = SqlDbType.Int;
                ParIdPedidos.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdPedidos);

                SqlParameter Parnombre = new SqlParameter();
                Parnombre.ParameterName = "@nombre";
                Parnombre.SqlDbType = SqlDbType.VarChar;
                Parnombre.Size = 100;
                Parnombre.Value = Urbanizacion.Nombre;
                SqlCmd.Parameters.Add(Parnombre);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = Urbanizacion.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParCiudad = new SqlParameter();
                ParCiudad.ParameterName = "@ciudad";
                ParCiudad.SqlDbType = SqlDbType.VarChar;
                ParCiudad.Size = 50;
                ParCiudad.Value = Urbanizacion.Ciudad;
                SqlCmd.Parameters.Add(ParCiudad);

                SqlParameter ParSuperficie = new SqlParameter();
                ParSuperficie.ParameterName = "@superficie";
                ParSuperficie.SqlDbType = SqlDbType.VarChar;
                ParSuperficie.Size = 50;
                ParSuperficie.Value = Urbanizacion.Superficie;
                SqlCmd.Parameters.Add(ParSuperficie);

                SqlParameter ParImagen = new SqlParameter();
                ParImagen.ParameterName = "@imagen";
                ParImagen.SqlDbType = SqlDbType.Image;
                ParImagen.Value = Urbanizacion.Imagen;
                SqlCmd.Parameters.Add(ParImagen);

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

        public string Editar(DUrbanizacion Urbanizacion)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_urbanizacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdPedidos = new SqlParameter();
                ParIdPedidos.ParameterName = "@codigou";
                ParIdPedidos.SqlDbType = SqlDbType.Int;
                ParIdPedidos.Value = Urbanizacion.Codigo_U;
                //ParIdPedidos.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdPedidos);

                SqlParameter Parnombre = new SqlParameter();
                Parnombre.ParameterName = "@nombre";
                Parnombre.SqlDbType = SqlDbType.VarChar;
                Parnombre.Size = 100;
                Parnombre.Value = Urbanizacion.Nombre;
                SqlCmd.Parameters.Add(Parnombre);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = Urbanizacion.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParCiudad = new SqlParameter();
                ParCiudad.ParameterName = "@ciudad";
                ParCiudad.SqlDbType = SqlDbType.VarChar;
                ParCiudad.Size = 50;
                ParCiudad.Value = Urbanizacion.Ciudad;
                SqlCmd.Parameters.Add(ParCiudad);

                SqlParameter ParSuperficie = new SqlParameter();
                ParSuperficie.ParameterName = "@superficie";
                ParSuperficie.SqlDbType = SqlDbType.VarChar;
                ParSuperficie.Size = 50;
                ParSuperficie.Value = Urbanizacion.Superficie;
                SqlCmd.Parameters.Add(ParSuperficie);

                SqlParameter ParImagen = new SqlParameter();
                ParImagen.ParameterName = "@imagen";
                ParImagen.SqlDbType = SqlDbType.Image;
                ParImagen.Value = Urbanizacion.Imagen;
                SqlCmd.Parameters.Add(ParImagen);

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

        public string Eliminar(DUrbanizacion Urbanizacion)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_urbanizacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdPedidos = new SqlParameter();
                ParIdPedidos.ParameterName = "@codigo";
                ParIdPedidos.SqlDbType = SqlDbType.Int;
                ParIdPedidos.Value = Urbanizacion.Codigo_U;
                //ParIdPedidos.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdPedidos);


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
        public DataTable Buscar(String Nombre)
        {
            DataTable DtResultado = new DataTable("Urbanizacion");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_urbanizacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParBnOMBRE = new SqlParameter();
                ParBnOMBRE.ParameterName = "@nombre";
                ParBnOMBRE.SqlDbType = SqlDbType.VarChar;
                ParBnOMBRE.Size = 50;
                ParBnOMBRE.Value = Nombre;
                SqlCmd.Parameters.Add(ParBnOMBRE);

              
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
            DataTable DtResultado = new DataTable("Urbanizacion");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_urbanizacion";
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

    }
}
