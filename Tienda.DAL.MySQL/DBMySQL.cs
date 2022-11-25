using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaCOMMON.Interfaces;

namespace Tienda.DAL.MySQL
{
    public class DBMySQL : IDB
    {
        private MySqlConnection conexion;
        public DBMySQL()
        {
            string server = "";
            string database = "";
            string uid = "";
            string password= "";
            conexion=new MySqlConnection(string.Format("SERVER={0};DATABASE{1};UID{2};PASSWORD{3};SslMode=none;",server,database,uid,password));
            Conectar();
        }

        private bool Conectar()
        {
            try
            {
                conexion.Open();
                Error = "";
                return true;
            }
            catch (MySqlException ex)
            {
                Error = ex.Message;
                return false;
                
            }
        }

        public string Error { get; private set; }

        public bool Comando(string command)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(command, conexion);
                cmd.ExecuteNonQuery();
                Error = "";
                return true;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return false;
                throw;
            }
        }

        public object Consulta(string consulta)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                Error = "";
                return dr;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                return null;
            }
        }
        ~DBMySQL()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}
