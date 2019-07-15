using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class DLotes
    {
        private int _Codigo;
        private int _Urbanizacion;
        private string _Superficie;
        private int _Nro_lotes;
        private string _Estado;
        private string _Descripcion;
        private string _Precio;
        private string _Sector;
        private byte[] _Imagen;

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

        public int Urbanizacion
        {
            get
            {
                return _Urbanizacion;
            }

            set
            {
                _Urbanizacion = value;
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

        public int Nro_lotes
        {
            get
            {
                return _Nro_lotes;
            }

            set
            {
                _Nro_lotes = value;
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

        public string Precio
        {
            get
            {
                return _Precio;
            }

            set
            {
                _Precio = value;
            }
        }

        public string Sector
        {
            get
            {
                return _Sector;
            }

            set
            {
                _Sector = value;
            }
        }

        public byte[] Imagen { get => _Imagen; set => _Imagen = value; }

        public DLotes()
        { }
        public DLotes(int codigo, int urbanizacion, string superficie, int nro, string estado, string descripcion, string precio, string sector, byte[] imagen)
        {
            this.Codigo = codigo;
            this.Urbanizacion = urbanizacion;
            this.Superficie = superficie;
            this.Nro_lotes = nro;
            this.Estado = estado;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Sector = sector;
            this.Imagen = imagen;
        }
        public string Insertar(DLotes Lotes)
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
                SqlCmd.CommandText = "spinsertar_lote";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdPedidos = new SqlParameter();
                ParIdPedidos.ParameterName = "@codigol";
                ParIdPedidos.SqlDbType = SqlDbType.Int;
                //ParIdPedidos.Value = Solicitud.Codigo;
                ParIdPedidos.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdPedidos);

                SqlParameter ParCargo = new SqlParameter();
                ParCargo.ParameterName = "@urbanizacion";
                ParCargo.SqlDbType = SqlDbType.Int;
                ParCargo.Value = Lotes.Urbanizacion;
                SqlCmd.Parameters.Add(ParCargo);

                SqlParameter Parnombre = new SqlParameter();
                Parnombre.ParameterName = "@superficie";
                Parnombre.SqlDbType = SqlDbType.VarChar;
                Parnombre.Size = 50;
                Parnombre.Value = Lotes.Superficie;
                SqlCmd.Parameters.Add(Parnombre);

                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@nro_lote";
                ParApellidos.SqlDbType = SqlDbType.Int;
                ParApellidos.Value = Lotes.Nro_lotes;
                SqlCmd.Parameters.Add(ParApellidos);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@estado";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 20;
                ParDireccion.Value = Lotes.Estado;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@descripcion";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParTelefono.Value = Lotes.Descripcion;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@precio";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 50;
                ParSexo.Value = Lotes.Precio;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@sector";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 100;
                ParEstado.Value = Lotes.Sector;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParImagen = new SqlParameter();
                ParImagen.ParameterName = "@imagen";
                ParImagen.SqlDbType = SqlDbType.Image;
                ParImagen.Value = Lotes.Imagen;
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

        public string Editar(DLotes Lotes)
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
                SqlCmd.CommandText = "speditar_lotes";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@codigol";
                ParCodigo.SqlDbType = SqlDbType.Int;
                ParCodigo.Value = Lotes.Codigo;
                //ParIdPedidos.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParCodigo);


                SqlParameter ParCargo = new SqlParameter();
                ParCargo.ParameterName = "@urbanizacion";
                ParCargo.SqlDbType = SqlDbType.Int;
                ParCargo.Value = Lotes.Urbanizacion;
                SqlCmd.Parameters.Add(ParCargo);

                SqlParameter Parnombre = new SqlParameter();
                Parnombre.ParameterName = "@superficie";
                Parnombre.SqlDbType = SqlDbType.VarChar;
                Parnombre.Size = 50;
                Parnombre.Value = Lotes.Superficie;
                SqlCmd.Parameters.Add(Parnombre);

                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@nro_lote";
                ParApellidos.SqlDbType = SqlDbType.Int;
                ParApellidos.Value = Lotes.Nro_lotes;
                SqlCmd.Parameters.Add(ParApellidos);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@estado";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 20;
                ParDireccion.Value = Lotes.Estado;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@descripcion";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParTelefono.Value = Lotes.Descripcion;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@precio";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 50;
                ParSexo.Value = Lotes.Precio;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@sector";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 100;
                ParEstado.Value = Lotes.Sector;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParImagen = new SqlParameter();
                ParImagen.ParameterName = "@imagen";
                ParImagen.SqlDbType = SqlDbType.Image;
                ParImagen.Value = Lotes.Imagen;
                SqlCmd.Parameters.Add(ParImagen);

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

        public string CambiarEstado(DLotes Lotes)
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
                SqlCmd.CommandText = "spcambiar_estado_lote";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@codigo";
                ParCodigo.SqlDbType = SqlDbType.Int;
                ParCodigo.Value = Lotes.Codigo;
                //ParIdPedidos.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParCodigo);


                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Actualizo el Estado";
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

        public string CambiarEstado2(DLotes Lotes)
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
                SqlCmd.CommandText = "spcambiar_estado_lote2";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@codigo";
                ParCodigo.SqlDbType = SqlDbType.Int;
                ParCodigo.Value = Lotes.Codigo;
                //ParIdPedidos.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParCodigo);


                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Actualizo el Estado";
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
        public string Eliminar(DLotes Lotes)
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
                SqlCmd.CommandText = "speliminar_lotes";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@codigo";
                ParCodigo.SqlDbType = SqlDbType.Int;
                ParCodigo.Value = Lotes.Codigo;
                SqlCmd.Parameters.Add(ParCodigo);

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

        public DataTable Buscar(String Estado, String Nro)
        {
            DataTable DtResultado = new DataTable("Lotes");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_lotes";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParEsatdo = new SqlParameter();
                ParEsatdo.ParameterName = "@estado";
                ParEsatdo.SqlDbType = SqlDbType.VarChar;
                ParEsatdo.Size = 50;
                ParEsatdo.Value = Estado;
                SqlCmd.Parameters.Add(ParEsatdo);

                SqlParameter ParNroLotes = new SqlParameter();
                ParNroLotes.ParameterName = "@nro_lotes";
                ParNroLotes.SqlDbType = SqlDbType.VarChar;
                ParNroLotes.Size = 50;
                ParNroLotes.Value = Nro;
                SqlCmd.Parameters.Add(ParNroLotes);

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
            DataTable DtResultado = new DataTable("Lotes");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_lotes";
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
        public DataTable MostrarVista()
        {
            DataTable DtResultado = new DataTable("Lotes");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_lotes_vistas";
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
                ParTextoBuscar2.ParameterName = "fecha2";
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
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
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
