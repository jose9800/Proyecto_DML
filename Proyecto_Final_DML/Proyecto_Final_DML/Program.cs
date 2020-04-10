using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_DML
{
    class Program
    {
        static void Main(string[] args)
        {
            Conexion_SQLServer conexion = new Conexion_SQLServer();

            Metodos obj_metodo = new Metodos();
            Console.WriteLine("Ingrese el nombre de la base de datos");
            string nombre = Console.ReadLine();
            //obj_metodo.CrearDB(nombre);
            obj_metodo.UsarDB(nombre);
            //obj_metodo.Insertar_en_tablas();
            obj_metodo.Modificar();

        }
    }
}
