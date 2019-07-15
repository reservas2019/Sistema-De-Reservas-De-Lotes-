using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Capa_Datos
{
   public class DUsuario
    {
        private int _CodigoU;
        private int _Cargo;
        private string _Nombre;
        private string _Apellidos;
        private string _Direccion;
        private DateTime _Fecha_Registro;
        private int _Telefono;
        private string _Sexo;
        private string _Estado;
        private string _Usuario;
        private string _Password;

        public int CodigoU
        {
            get
            {
                return _CodigoU;
            }

            set
            {
                _CodigoU = value;
            }
        }

        public int Cargo
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

        public string Apellidos
        {
            get
            {
                return _Apellidos;
            }

            set
            {
                _Apellidos = value;
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

        public int Telefono
        {
            get
            {
                return _Telefono;
            }

            set
            {
                _Telefono = value;
            }
        }

        public string Sexo
        {
            get
            {
                return _Sexo;
            }

            set
            {
                _Sexo = value;
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

        public string Usuario
        {
            get
            {
                return _Usuario;
            }

            set
            {
                _Usuario = value;
            }
        }

        public string Password
        {
            get
            {
                return _Password;
            }

            set
            {
                _Password = value;
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

        public string Insertar(DUsuario Usuario)
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
                SqlCmd.CommandText = "spinsertar_usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdPedidos = new SqlParameter();
                ParIdPedidos.ParameterName = "@codigoU";
                ParIdPedidos.SqlDbType = SqlDbType.Int;
                //ParIdPedidos.Value = Solicitud.Codigo;
                ParIdPedidos.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdPedidos);

                SqlParameter ParCargo = new SqlParameter();
                ParCargo.ParameterName = "@cargo";
                ParCargo.SqlDbType = SqlDbType.Int;
                ParCargo.Value = Usuario.Cargo;
                SqlCmd.Parameters.Add(ParCargo);

                SqlParameter Parnombre = new SqlParameter();
                Parnombre.ParameterName = "@nombre";
                Parnombre.SqlDbType = SqlDbType.VarChar;
                Parnombre.Size = 50;
                Parnombre.Value = Usuario.Nombre;
                SqlCmd.Parameters.Add(Parnombre);

                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@apellidos";
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                ParApellidos.Size = 100;
                ParApellidos.Value = Usuario.Apellidos;
                SqlCmd.Parameters.Add(ParApellidos);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = Usuario.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha";
                ParFecha.SqlDbType = SqlDbType.DateTime;
                ParFecha.Value = Usuario.Fecha_Registro;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.Int;
                ParTelefono.Value = Usuario.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 2;
                ParSexo.Value = Usuario.Sexo;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 20;
                ParEstado.Value = Usuario.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 100;
                ParUsuario.Value = Usuario.Usuario;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParPassowrd = new SqlParameter();
                ParPassowrd.ParameterName = "@password";
                ParPassowrd.SqlDbType = SqlDbType.VarChar;
                ParPassowrd.Size = 100;
                ParPassowrd.Value = Usuario.Password;
                SqlCmd.Parameters.Add(ParPassowrd);

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

        public string Editar(DUsuario Usuario)
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
                SqlCmd.CommandText = "speditar_usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@codigoU";
                ParCodigo.SqlDbType = SqlDbType.Int;
                ParCodigo.Value = Usuario.CodigoU;
                //ParIdPedidos.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParCodigo);

                SqlParameter ParCargo = new SqlParameter();
                ParCargo.ParameterName = "@cargo";
                ParCargo.SqlDbType = SqlDbType.Int;
                ParCargo.Value = Usuario.Cargo;
                SqlCmd.Parameters.Add(ParCargo);

                SqlParameter Parnombre = new SqlParameter();
                Parnombre.ParameterName = "@nombre";
                Parnombre.SqlDbType = SqlDbType.VarChar;
                Parnombre.Size = 50;
                Parnombre.Value = Usuario.Nombre;
                SqlCmd.Parameters.Add(Parnombre);

                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@apellidos";
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                ParApellidos.Size = 100;
                ParApellidos.Value = Usuario.Apellidos;
                SqlCmd.Parameters.Add(ParApellidos);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = Usuario.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.Int;
                ParTelefono.Value = Usuario.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 2;
                ParSexo.Value = Usuario.Sexo;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 20;
                ParEstado.Value = Usuario.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 100;
                ParUsuario.Value = Usuario.Usuario;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParPassowrd = new SqlParameter();
                ParPassowrd.ParameterName = "@password";
                ParPassowrd.SqlDbType = SqlDbType.VarChar;
                ParPassowrd.Size = 100;
                ParPassowrd.Value = Usuario.Password;
                SqlCmd.Parameters.Add(ParPassowrd);

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

        public DataTable Buscar(String Nombre, String txt1, String txt2)
        {
            DataTable DtResultado = new DataTable("Usuario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParBnOMBRE = new SqlParameter();
                ParBnOMBRE.ParameterName = "@nombre";
                ParBnOMBRE.SqlDbType = SqlDbType.VarChar;
                ParBnOMBRE.Size = 50;
                ParBnOMBRE.Value = Nombre;
                SqlCmd.Parameters.Add(ParBnOMBRE);

                SqlParameter ParF1 = new SqlParameter();
                ParF1.ParameterName = "@fecha1";
                ParF1.SqlDbType = SqlDbType.VarChar;
                ParF1.Size = 50;
                ParF1.Value = txt1;
                SqlCmd.Parameters.Add(ParF1);

                SqlParameter ParF2 = new SqlParameter();
                ParF2.ParameterName = "@fecha2";
                ParF2.SqlDbType = SqlDbType.VarChar;
                ParF2.Size = 50;
                ParF2.Value = txt2;
                SqlCmd.Parameters.Add(ParF2);

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
            DataTable DtResultado = new DataTable("usuario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_usuario";
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

        public string Elminar(DUsuario Usuario)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter Parnombre = new SqlParameter();
                Parnombre.ParameterName = "@codigoU";
                Parnombre.SqlDbType = SqlDbType.Int;
                //Parnombre.Size = 50;
                Parnombre.Value = Usuario.CodigoU;
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

        public DataTable LOGIN(DUsuario Usuario)
        {
            DataTable DtResultado = new DataTable("Usuario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_Login";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 20;
                ParUsuario.Value = Usuario.Usuario;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@password";
                ParPassword.SqlDbType = SqlDbType.VarChar;
                ParPassword.Size = 50;
                ParPassword.Value = Usuario.Password;
                SqlCmd.Parameters.Add(ParPassword);

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
