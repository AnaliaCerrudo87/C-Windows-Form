using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class Empleadoconexion
    {
        public List<Empleados> ListarEmpleados()
        {
            List<Empleados> lista = new List<Empleados>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            //En Data Source colocar dirección de su servidor local

            conexion.ConnectionString = "Data Source="";Initial Catalog=EMPLEADOS_DB;Integrated Security=True";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Select  ID,NombreCompleto,DNI,Edad,Casado,Salario from Empleado ";
            comando.Connection = conexion;
            conexion.Open();

            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Empleados aux = new Empleados();
                aux.Id = (int)lector["ID"];
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
        public void agregarEmpleado(Empleados empleado)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            //En Data Source colocar dirección de su servidor local

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

        public void modificarEmpleado(Empleados empleado, string documento)


        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            //En Data Source colocar dirección de su servidor local

            conexion.ConnectionString = "Data Source="";Initial Catalog=EMPLEADOS_DB;Integrated Security=True";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "UPDATE Empleado SET NombreCompleto= @NombreCompleto,Edad=@Edad,Casado=@Casado,Salario=@Salario Where Dni=@documento";
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@NombreCompleto", empleado.Nombrecompleto);
            comando.Parameters.AddWithValue("@documento", documento);
            comando.Parameters.AddWithValue("@Edad", empleado.Edad);
            comando.Parameters.AddWithValue("@Casado", empleado.Casado);
            comando.Parameters.AddWithValue("@Salario", empleado.Salario);


            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();



        }

        public void eliminarEmpleado(Empleados empleado)


        {

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            string dni;
            dni = empleado.Dni;

            //En Data Source colocar dirección de su servidor local

            conexion.ConnectionString = "Data Source="";Initial Catalog=EMPLEADOS_DB;Integrated Security=True";
            comando.CommandType = System.Data.CommandType.Text;

            comando.CommandText = "DELETE FROM Empleado WHERE Dni=@dni";
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@Dni", empleado.Dni);


            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();



        }

        
    }
}
    
