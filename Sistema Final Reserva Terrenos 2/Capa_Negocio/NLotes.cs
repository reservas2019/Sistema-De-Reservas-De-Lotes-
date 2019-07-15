using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Datos;

namespace Capa_Negocio
{
   public class NLotes
    {
        public static string Insertar(int urbanizacion,string superficie, int nro_lote,string estado,string descripcion,string precio,string sector,byte[] imagen)
        {
            DLotes Obj = new DLotes();
            Obj.Urbanizacion = urbanizacion;
            Obj.Superficie = superficie;
            Obj.Nro_lotes = nro_lote;
            Obj.Estado = estado;
            Obj.Descripcion = descripcion;
            Obj.Precio = precio;
            Obj.Sector = sector;
            Obj.Imagen = imagen;

            return Obj.Insertar(Obj);
        }
        public static string Editar(int codigo, int urbanizacion, string superficie, int nro_lote, string estado, string descripcion, string precio, string sector, byte[] imagen)
        {
            DLotes Obj = new DLotes();
            Obj.Codigo = codigo;
            Obj.Urbanizacion = urbanizacion;
            Obj.Superficie = superficie;
            Obj.Nro_lotes = nro_lote;
            Obj.Estado = estado;
            Obj.Descripcion = descripcion;
            Obj.Precio = precio;
            Obj.Sector = sector;
            Obj.Imagen = imagen;

            return Obj.Editar(Obj);
        }
        public static string CambiarEstado(int codigo)
        {
            DLotes Obj = new DLotes();
            Obj.Codigo = codigo;

            return Obj.CambiarEstado(Obj);
        }
        public static string CambiarEstado2(int codigo)
        {
            DLotes Obj = new DLotes();
            Obj.Codigo = codigo;

            return Obj.CambiarEstado2(Obj);
        }
        public static string Eliminar(int codigo)
        {
            DLotes Obj = new DLotes();
            Obj.Codigo = codigo;

            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DLotes().Mostrar();
        }
        public static DataTable MostrarVistas()
        {
            return new DLotes().MostrarVista();
        }
        public static DataTable Buscar(string estado, string nro)
        {
            return new DLotes().Buscar(estado, nro);
        }
    }
}
