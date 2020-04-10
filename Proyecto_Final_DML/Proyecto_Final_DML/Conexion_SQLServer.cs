using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Libreria
using System.Data.SqlClient;

namespace Proyecto_Final_DML
{
    class Conexion_SQLServer
    {
        //Cadena de conexion

        //string conexion = @"Data Source=DESKTOP-0OJ1B95\SQLEXPRESS;Initial Catalog=Futbol;Integrated Security=True";

        //public SqlConnection obj_conexion = new SqlConnection();

        ////Constructor
        //public Conexion_SQLServer()
        //{
        //    obj_conexion.ConnectionString = conexion;
        //}

        ////Abrir la conexión
        //public void AbrirConexion()
        //{
        //    try {
        //        obj_conexion.Open();
        //        Console.WriteLine("Conexión abierta");
        //        Console.ReadKey();
        //    }
        //    catch (SqlException e) {
        //        Console.WriteLine(e);
        //    }
        //}
        //public void CerrarConexion()
        //{
        //    obj_conexion.Close();
        //}

        private SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-0OJ1B95\SQLEXPRESS;Initial Catalog=Futbol;Integrated Security=True");
        //Abrir conexion
        public SqlConnection AbrirConexion() {
            conexion.Open();
            return conexion;
        }
        //Cerrar conexion
        public SqlConnection CerrarConexion() {
            conexion.Close();
            return conexion;
        }
    }
}
