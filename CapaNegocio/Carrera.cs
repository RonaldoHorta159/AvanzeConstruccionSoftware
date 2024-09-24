using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration; //Cadena de conexion

namespace CapaNegocio
{
    internal class Carrera
    {
        //cadena de conexion
        private static string cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;



        // mapear las columnas de la tabla en propiedas de la clase
        public string CodCarrera { get; set; }
        public string NombreCarrera { get; set; }

        //implmentar los metodos de clase
        public DataTable Listar()
        {
            using (SqlConnection conexion = new SqlConnection())
            {
                string consulta = "select * from TCarrera";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                return tabla;
            }
        }
        public bool Agregar()
        {
            using(SqlConnection conexion = new SqlConnection())
            {
                string consulta = "insert into TCarrera values (CodCarrera=@CodCarrera, Carrera = @NombreCarrera)";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@CodCarrera", CodCarrera);
                comando.Parameters.AddWithValue("@NombreCarrera", NombreCarrera);
                conexion.Open();
                byte i = Convert.ToByte(comando.ExecuteNonQuery());
                if (i == 1) return true;
                else return false;
            }
        }
        public bool Eliminar()
        {
            using (SqlConnection conexion = new SqlConnection())
            {
                string consulta = "delete from TCarrera where CodCarrera = @CodCarrera";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@CodCarrera", CodCarrera);
                conexion.Open();
                byte i = Convert.ToByte(comando.ExecuteNonQuery());
                if (i == 1) return true;
                else return false;
            }
        }
        public bool Actualizar()
        {
            using (SqlConnection conexion = new SqlConnection())
            {
                string consulta = "update TCarrera set Carrera=@NombreCarrera where CodCarrera=@CodCarrera";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@CodCarrera", CodCarrera);
                comando.Parameters.AddWithValue("@NombreCarrera", NombreCarrera);
                conexion.Open();
                byte i = Convert.ToByte(comando.ExecuteNonQuery());
                if (i == 1) return true;
                else return false;
            }
        }
        public DataTable Buscar()
        {
            using (SqlConnection conexion = new SqlConnection())
            {
                string consulta = "select * from TCarerra where CodCarrera = @CodCarrera";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@CodCarerra", CodCarrera);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                return tabla;
            }
        }
    }
}
