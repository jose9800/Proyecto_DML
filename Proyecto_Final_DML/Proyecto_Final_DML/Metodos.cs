using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Librerias  necesarias
using System.Data.SqlClient;
using System.Data;

namespace Proyecto_Final_DML
{
    class Metodos
    {
        //Insanciar un objeto de la clase Conexion_SQLServer
        private Conexion_SQLServer conexionSQLServer = new Conexion_SQLServer();
        //Instanciar un objeto que reconozca sentencias sql server
        SqlCommand comando = new SqlCommand();
        SqlDataReader leerdatos;

        //El método CrearDB lo mantenmos para ver si hay comunicacion entre el programa y el gestor

        public void CrearDB(string NombreDB)
        {
            comando.Connection = conexionSQLServer.AbrirConexion();
            comando.CommandText = "create database " + NombreDB + ";";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.Connection = conexionSQLServer.CerrarConexion();
        }
        //Seleccionar la base de datos que usaremos

        public void UsarDB(string NombreDB) {
            comando.Connection = conexionSQLServer.AbrirConexion();
            comando.CommandText = "use " + NombreDB + ";";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.Connection = conexionSQLServer.CerrarConexion();
        }

        public void Insertar_en_tablas() {
            comando.Connection = conexionSQLServer.AbrirConexion();
            Console.WriteLine("Ingresa tu sentencia");
            comando.CommandText = Console.ReadLine();
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.Connection = conexionSQLServer.CerrarConexion();
        }
        public void Modificar(){
            comando.Connection = conexionSQLServer.AbrirConexion();
            Console.WriteLine("Modifica la tabla");
            comando.CommandText = Console.ReadLine();
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            comando.Connection = conexionSQLServer.CerrarConexion();
        }
        public void Selecionar() {

        }
    }
}
