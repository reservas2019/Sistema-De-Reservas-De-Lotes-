using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Datos;

namespace Capa_Negocio
{
    public class NReserva
    {
        public static string Insertar(int cliente,int usuario,int cantidad,string estado, DateTime fecha_registro,
           DateTime fecha_limite,string Precio_Total, DataTable dtDetalles)
        {
            DReserva Obj = new DReserva();
            Obj.Cliente = cliente;
            Obj.Usuario = usuario;
            Obj.Cantidad = cantidad;
            Obj.Estado = estado;
            Obj.Fecha_registro = fecha_registro;
            Obj.Fecha_Limite = fecha_limite;
            Obj.Precio_Total = Precio_Total;

            List<DDetalleReserva> detalles = new List<DDetalleReserva>();
            foreach (DataRow row in dtDetalles.Rows)
            {
                DDetalleReserva detalle = new DDetalleReserva();
                //detalle.Reserva = Convert.ToInt32(row["Cliente"].ToString());
                detalle.Lotes = Convert.ToInt32(row["Lote"].ToString());
                detalle.Precio_Unitario = (row["Precio_Unitario"].ToString());

        detalles.Add(detalle);
            }
            return Obj.Insertar(Obj, detalles);
        }

        public static string Editar(int codigo, int cliente, int usuario, int cantidad,string estado,string precio_total, DataTable dtDetalles)
        {
            DReserva Obj = new DReserva();
            Obj.Codigo = codigo;
            Obj.Cliente = cliente;
            Obj.Usuario = usuario;
            Obj.Cantidad = cantidad;
            Obj.Estado = estado;
            Obj.Precio_Total = precio_total;

            List<DDetalleReserva> detalles = new List<DDetalleReserva>();
            foreach (DataRow row in dtDetalles.Rows)
            {
                DDetalleReserva detalle = new DDetalleReserva();
                //detalle.Reserva = Convert.ToInt32(row["Reserva"].ToString());
                detalle.Lotes = Convert.ToInt32(row["Lote"].ToString());
                detalle.Precio_Unitario = (row["Precio_Unitario"].ToString());

                detalles.Add(detalle);
            }
            return Obj.Editar(Obj, detalles);
        }
        public static DataTable Mostrar()
        {
            return new DReserva().Mostrar();
        }

        public static DataTable Buscar(string nombre, string estado, string textobuscar, string textobuscar2)
        {
            DReserva Obj = new DReserva();
            return Obj.Buscar(nombre, estado, textobuscar, textobuscar2);
        }
        public static DataTable MostrarDetalle(string textobuscar)
        {
            DReserva Obj = new DReserva();
            return Obj.MostrarDetalle(textobuscar);
        }
        public static string Eliminar(int codigo)
        {
            DReserva Obj = new DReserva();
            Obj.Codigo = codigo;
            return Obj.Eliminar(Obj);
        }
    }
}
