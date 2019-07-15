using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Datos;

namespace Capa_Negocio
{
   public class NUrbanizacion
    {
        public static string Insertar(string nombre, string direccion,string ciudad,string superficie, byte[] imagen)
        {
            DUrbanizacion Obj = new DUrbanizacion();
            Obj.Nombre = nombre;
            Obj.Direccion = direccion;
            Obj.Ciudad = ciudad;
            Obj.Superficie = superficie;
            Obj.Imagen = imagen;

            return Obj.Insertar(Obj);
        }
        public static string Editar(int codigo, string nombre, string direccion, string ciudad, string superficie, byte[] imagen)
        {
            DUrbanizacion Obj = new DUrbanizacion();
            Obj.Codigo_U = codigo;
            Obj.Nombre = nombre;
            Obj.Direccion = direccion;
            Obj.Ciudad = ciudad;
            Obj.Superficie = superficie;
            Obj.Imagen = imagen;

            return Obj.Editar(Obj);
        }

        public static string Eliminar(int codigo)
        {
            DUrbanizacion Obj = new DUrbanizacion();
            Obj.Codigo_U = codigo;

            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DUrbanizacion().Mostrar();
        }
        public static DataTable Buscar (string nombre)
        {
            return new DUrbanizacion().Buscar(nombre);
        }
    }
}
