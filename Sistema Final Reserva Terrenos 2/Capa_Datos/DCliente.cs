using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
   public class DCliente
    {
        private int _Codigo;
        private string _Nombres;
        private string _Apellidos;
        private string _Sexo;
        private int _Edad;
        private DateTime _FechaNa_cimiento;
        private int _CI;
        private int _Telefono;
        private string _Pais;
        private string _Direccion;
        private string _Email;
        private DateTime _Fecha_Registro;

        public int Codigo
        {
            get
            {
                return _Codigo;
            }

            set
            {
                _Codigo = value;
            }
        }

        public string Nombres
        {
            get
            {
                return _Nombres;
            }

            set
            {
                _Nombres = value;
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

        public int Edad
        {
            get
            {
                return _Edad;
            }

            set
            {
                _Edad = value;
            }
        }

        public DateTime FechaNa_cimiento
        {
            get
            {
                return _FechaNa_cimiento;
            }

            set
            {
                _FechaNa_cimiento = value;
            }
        }

        public int CI
        {
            get
            {
                return _CI;
            }

            set
            {
                _CI = value;
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

        public string Pais
        {
            get
            {
                return _Pais;
            }

            set
            {
                _Pais = value;
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

        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
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

        public DCliente()
        { }

        public DCliente(int codigo, string nombres,string apellidos,string sexo,int edad,DateTime fechanac,int ci,int telefono,string pais,string direccion,string email,DateTime fecha_reg)
        {
            this.Codigo = codigo;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Sexo = sexo;
            this.Edad = edad;
            this.FechaNa_cimiento = fechanac;
            this.CI = ci;
            this.Telefono = telefono;
            this.Pais = pais;
            this.Direccion = direccion;
            this.Email = email;
            this.Fecha_Registro = fecha_reg;
        }
        public string Insertar(DCliente Cliente)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDCliente = new SqlParameter();
                ParIDCliente.ParameterName = "@codigoc";
                ParIDCliente.SqlDbType = SqlDbType.Int;
                //ParIdPedidos.Value = Solicitud.Codigo;
                ParIDCliente.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIDCliente);

                SqlParameter Parnombre = new SqlParameter();
                Parnombre.ParameterName = "@nombres";
                Parnombre.SqlDbType = SqlDbType.VarChar;
                Parnombre.Size = 50;
                Parnombre.Value = Cliente.Nombres;
                SqlCmd.Parameters.Add(Parnombre);

                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@apellidos";
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                ParApellidos.Size = 100;
                ParApellidos.Value = Cliente.Apellidos;
                SqlCmd.Parameters.Add(ParApellidos);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 2;
                ParSexo.Value = Cliente.Sexo;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParEdad = new SqlParameter();
                ParEdad.ParameterName = "@edad";
                ParEdad.SqlDbType = SqlDbType.Int;
                ParEdad.Value = Cliente.Edad;
                SqlCmd.Parameters.Add(ParEdad);

                SqlParameter ParFechNac = new SqlParameter();
                ParFechNac.ParameterName = "@fecha_nacimiento";
                ParFechNac.SqlDbType = SqlDbType.DateTime;
                ParFechNac.Value = Cliente.FechaNa_cimiento;
                SqlCmd.Parameters.Add(ParFechNac);

                SqlParameter ParCI = new SqlParameter();
                ParCI.ParameterName = "@ci";
                ParCI.SqlDbType = SqlDbType.Int;
                ParCI.Value = Cliente.CI;
                SqlCmd.Parameters.Add(ParCI);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.Int;
                ParTelefono.Value = Cliente.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParPais = new SqlParameter();
                ParPais.ParameterName = "@pais";
                ParPais.SqlDbType = SqlDbType.VarChar;
                ParPais.Size = 50;
                ParPais.Value = Cliente.Pais;
                SqlCmd.Parameters.Add(ParPais);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = Cliente.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 100;
                ParEmail.Value = Cliente.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParFechReg = new SqlParameter();
                ParFechReg.ParameterName = "@fecha_registro";
                ParFechReg.SqlDbType = SqlDbType.DateTime;
                ParFechReg.Value = Cliente.Fecha_Registro;
                SqlCmd.Parameters.Add(ParFechReg);

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

        public string Editar(DCliente Cliente)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdPedidos = new SqlParameter();
                ParIdPedidos.ParameterName = "@codigoc";
                ParIdPedidos.SqlDbType = SqlDbType.Int;
                ParIdPedidos.Value = Cliente.Codigo;
                //ParIdPedidos.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdPedidos);

                SqlParameter Parnombre = new SqlParameter();
                Parnombre.ParameterName = "@nombres";
                Parnombre.SqlDbType = SqlDbType.VarChar;
                Parnombre.Size = 50;
                Parnombre.Value = Cliente.Nombres;
                SqlCmd.Parameters.Add(Parnombre);

                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@apellidos";
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                ParApellidos.Size = 100;
                ParApellidos.Value = Cliente.Apellidos;
                SqlCmd.Parameters.Add(ParApellidos);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 2;
                ParSexo.Value = Cliente.Sexo;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParEdad = new SqlParameter();
                ParEdad.ParameterName = "@edad";
                ParEdad.SqlDbType = SqlDbType.Int;
                ParEdad.Value = Cliente.Edad;
                SqlCmd.Parameters.Add(ParEdad);

                SqlParameter ParFechNac = new SqlParameter();
                ParFechNac.ParameterName = "@fecha_nacimiento";
                ParFechNac.SqlDbType = SqlDbType.DateTime;
                ParFechNac.Value = Cliente.FechaNa_cimiento;
                SqlCmd.Parameters.Add(ParFechNac);

                SqlParameter ParCI = new SqlParameter();
                ParCI.ParameterName = "@ci";
                ParCI.SqlDbType = SqlDbType.Int;
                ParCI.Value = Cliente.CI;
                SqlCmd.Parameters.Add(ParCI);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.Int;
                ParTelefono.Value = Cliente.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParPais = new SqlParameter();
                ParPais.ParameterName = "@pais";
                ParPais.SqlDbType = SqlDbType.VarChar;
                ParPais.Size = 50;
                ParPais.Value = Cliente.Pais;
                SqlCmd.Parameters.Add(ParPais);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = Cliente.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 100;
                ParEmail.Value = Cliente.Email;
                SqlCmd.Parameters.Add(ParEmail);

     

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Edito el Registro";
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

        public string Eliminar(DCliente Cliente)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdPedidos = new SqlParameter();
                ParIdPedidos.ParameterName = "@codigo";
                ParIdPedidos.SqlDbType = SqlDbType.Int;
                ParIdPedidos.Value = Cliente.Codigo;
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

        public DataTable Buscar(String Nombre, String Sexo, String Ci)
        {
            DataTable DtResultado = new DataTable("cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 50;
                ParSexo.Value = Sexo;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParCI = new SqlParameter();
                ParCI.ParameterName = "@ci";
                ParCI.SqlDbType = SqlDbType.VarChar;
                ParCI.Size = 50;
                ParCI.Value = Ci;
                SqlCmd.Parameters.Add(ParCI);

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
            DataTable DtResultado = new DataTable("cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_cliente";
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
