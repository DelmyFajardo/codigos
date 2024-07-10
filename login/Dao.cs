using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace login
{
    internal class Dao
    {
        private string connectionString = "server=localhost;" +
               "user=root;" +
               "password=;" +
               "database=alumnodb;";



        //  CREATE TABLE `alumnodb`.`estudiante` (`Id` INT NOT NULL AUTO_INCREMENT, `Nombre` VARCHAR(100) NOT NULL, `Apellido` VARCHAR(100) NOT NULL, `Curso` VARCHAR(100) NOT NULL, PRIMARY KEY(`Id`)) ENGINE = InnoDB;

        public List<Bienvenido> ObtenerTodosLosProductos()
        {
            List<Bienvenido> listaEstudiantes = new List<Bienvenido>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                //aperturar conexion
                conn.Open();
                //diseñar la consulta
                string query = "SELECT Id, Nombre, Apellido, Curso, Carnet FROM estudiante";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Bienvenido Alumno = new Bienvenido();
                            Alumno.Id = Convert.ToInt32(reader["Id"]);
                            Alumno.Nombre = reader["Nombre"].ToString();
                            Alumno.Apellido = reader["Apellido"].ToString();
                            Alumno.Curso = reader["Curso"].ToString();
                            Alumno.Carnet = reader["Carnet"].ToString();

                            listaEstudiantes.Add(Alumno);
                        }
                    }
                }
            }

            return listaEstudiantes;
        }


        public Bienvenido AlumnoPorId(int Id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT Id, Nombre, Apellido, Curso, Carnet,  FROM estudiante WHERE Id = @Id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Bienvenido alumno = new Bienvenido();
                            alumno.Id = Convert.ToInt32(reader["Id"]);
                            alumno.Nombre = reader["Nombre"].ToString();
                            alumno.Apellido = reader["Apellido"].ToString();
                            alumno.Curso = reader["curso"].ToString();
                            alumno.Carnet = reader["carnet"].ToString();


                            return alumno;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public void ActualizarAlumno(Bienvenido Alumno)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE estudiante SET Nombre = @Nombre, Apellido = @Apellido, " +
                    "Curso = @Curso, Carnet = @Carnet, WHERE Id = @Id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", Alumno.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", Alumno.Apellido);
                    cmd.Parameters.AddWithValue("@Curso", Alumno.Curso);
                    cmd.Parameters.AddWithValue("@Carnet", Alumno.Carnet);
                    cmd.Parameters.AddWithValue("@Id", Alumno.Id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para eliminar un producto de la base de datos por su ID
        public void EliminarAlumno(int Id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM estudiante WHERE Id = @Id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void InsertarAlumno(Bienvenido Alumno)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO estudiante (Nombre, Apellido, Curso, Carnet) VALUES " +
                    "(@Nombre, @Apellido, @Curso, @Carnet)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", Alumno.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", Alumno.Apellido);
                    cmd.Parameters.AddWithValue("@Curso", Alumno.Curso);
                    cmd.Parameters.AddWithValue("@Carnet", Alumno.Carnet);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        internal class MySqlConnection
        {
            internal readonly ConnectionState State;
            private string connectionString;

            public MySqlConnection(string connectionString)
            {
                this.connectionString = connectionString;
            }

            internal void Open()
            {
                throw new NotImplementedException();
            }
        }


    }

    
}