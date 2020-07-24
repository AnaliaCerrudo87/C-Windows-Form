using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace BD
{
    class Empleadoconexion
    {
        public List<Empleados> ListarEmpleados()
        {
            List<Empleados> lista = new List<Empleados>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            //En Data Source colocar la dirección de su servidor Local
            
            conexion.ConnectionString = "Data Source="";Initial Catalog=EMPLEADOS_DB;Integrated Security=True";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Select * from Empleado ";
            comando.Connection = conexion;
            conexion.Open();

            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Empleados aux = new Empleados();
                aux.Id = lector.GetInt32(0);
                aux.Nombrecompleto = lector.GetString(1);
                aux.Dni = lector.GetString(2);
                aux.Edad = lector.GetInt32(3);
                aux.Casado = lector.GetBoolean(4);
                aux.Salario = lector.GetDecimal(5);

                lista.Add(aux);
            }
            conexion.Close();

            return lista;
        }
        public void agregarAlbum(Empleados empleado)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

             //En Data Source colocar la dirección de su servidor Local
            
            conexion.ConnectionString = "Data Source="";Initial Catalog=EMPLEADOS_DB;Integrated Security=True";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "insert into Empleado values (@NombreCompleto,@DNI,@Edad,@Casado,@Salario)";
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@NombreCompleto", empleado.Nombrecompleto);
            comando.Parameters.AddWithValue("@DNI", empleado.Dni);
            comando.Parameters.AddWithValue("@Edad", empleado.Edad);
            comando.Parameters.AddWithValue("@Casado", empleado.Casado);
            comando.Parameters.AddWithValue("@Salario", empleado.Salario);

            conexion.Open();
            comando.ExecuteNonQuery();

            conexion.Close();
        }
    }
}
