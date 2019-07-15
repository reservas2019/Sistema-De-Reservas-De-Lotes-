using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Datos;

namespace Capa_Negocio
{
   public class NUsuario
    {
        public static string Insertar(int cargo, string nombre, string apellidos, string direccion,DateTime fecha, int telefono, string sexo, string estado, string usuaario, string password)
        {
            DUsuario Obj = new DUsuario();
            Obj.Cargo = cargo;
            Obj.Nombre = nombre;
            Obj.Apellidos = apellidos;
            Obj.Direccion = direccion;
            Obj.Fecha_Registro = fecha;
            Obj.Telefono = telefono;
            Obj.Sexo = sexo;
            Obj.Estado = estado;
            Obj.Usuario = usuaario;
            Obj.Password = password;

            return Obj.Insertar(Obj);
        }

        public static string Editar(int codigo, int cargo, string nombre, string apellidos, string direccion, int telefono, string sexo, string estado, string usuaario, string password)
        {
            DUsuario Obj = new DUsuario();
            Obj.CodigoU = codigo;
            Obj.Cargo = cargo;
            Obj.Nombre = nombre;
            Obj.Apellidos = apellidos;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Sexo = sexo;
            Obj.Estado = estado;
            Obj.Usuario = usuaario;
            Obj.Password = password;

            return Obj.Editar(Obj);
        }

        public static string Eliminar(int codigo)
        {
            DUsuario Obj = new DUsuario();
            Obj.CodigoU = codigo;

            return Obj.Elminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DUsuario().Mostrar();
        }

        public static DataTable Buscar(string nombre, string t1, string t2)
        {
            DUsuario Obj = new DUsuario();

            return Obj.Buscar(nombre, t1, t2);
        }
        public static DataTable LOGIN(string usuario, string password)
        {
            DUsuario Obj = new DUsuario();
            Obj.Usuario = usuario;
            Obj.Password = password;
            return Obj.LOGIN(Obj);
        }
    }
}
