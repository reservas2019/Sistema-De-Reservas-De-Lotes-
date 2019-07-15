using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Datos;

namespace Capa_Negocio
{
   public class NCargos
    {
        public static string Insertar(string cargo, DateTime fecha_registro, string estado, string descripcion)
        {
            DCargos Obj = new DCargos();
            Obj.Cargo = cargo;
            Obj.Fecha_Registro = fecha_registro;
            Obj.Estado = estado;
            Obj.Descripcion = descripcion;

            return Obj.Insertar(Obj);
        }

        public static string Editar(int codigo, string cargo, string estado, string descripcion)
        {
            DCargos Obj = new DCargos();
            Obj.CodigoC = codigo;
            Obj.Cargo = cargo;
            Obj.Estado = estado;
            Obj.Descripcion = descripcion;

            return Obj.Editar(Obj);
        }

        public static string Eliminar(int codigo)
        {
            DCargos Obj = new DCargos();
            Obj.CodigoC = codigo;
            return Obj.Elminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DCargos().Mostrar();
        }

        public static DataTable Buscar(string cargo, string estado)
        {
            return new DCargos().Buscar(cargo, estado);
        }

    }
}
