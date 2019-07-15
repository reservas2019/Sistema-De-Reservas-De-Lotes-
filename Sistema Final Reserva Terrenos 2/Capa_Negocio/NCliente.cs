using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Datos;

namespace Capa_Negocio
{
   public class NCliente
    {
        public static string Insertar(string nombre, string apellidos, string sexo,int edad, DateTime fecha_nac, int ci, int telefono,string pais,string direccion,string email,DateTime fecha_regis)
        {
            DCliente obj = new DCliente();
            obj.Nombres = nombre;
            obj.Apellidos = apellidos;
            obj.Sexo = sexo;
            obj.Edad = edad;
            obj.FechaNa_cimiento = fecha_nac;
            obj.CI = ci;
            obj.Telefono = telefono;
            obj.Pais = pais;
            obj.Direccion = direccion;
            obj.Email = email;
            obj.Fecha_Registro = fecha_regis;

            return obj.Insertar(obj);
        }

        public static string Editar(int codigo, string nombre, string apellidos, string sexo, int edad, DateTime fecha_nac, int ci, int telefono, string pais, string direccion, string email)
        {
            DCliente obj = new DCliente();
            obj.Codigo = codigo;
            obj.Nombres = nombre;
            obj.Apellidos = apellidos;
            obj.Sexo = sexo;
            obj.Edad = edad;
            obj.FechaNa_cimiento = fecha_nac;
            obj.CI = ci;
            obj.Telefono = telefono;
            obj.Pais = pais;
            obj.Direccion = direccion;
            obj.Email = email;
           

            return obj.Editar(obj);
        }
        public static string Eliminar(int codigo)
        {
            DCliente obj = new DCliente();
            obj.Codigo = codigo;

            return obj.Eliminar(obj);
        }

        public static DataTable Mostrar()
        {
            DCliente obj = new DCliente();
            return obj.Mostrar();
        }

        public static DataTable Buscar(string nombre, string sexo, string ci)
        {
            return new DCliente().Buscar(nombre, sexo,ci);
        }
    }
}
