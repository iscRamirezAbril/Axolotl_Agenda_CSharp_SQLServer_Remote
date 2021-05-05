using System.Data.SqlClient; // Librería que nos permitirá conectarnos a las bases de datos de "SQL Server".

namespace ProyectoFinal
{
    /*
       Esta clase se creó específicamente para crear la connexión a la base de datos de
       SQL Server. La clase contiene un método de nombre "getConnection", que se encarga de
       realizar dicha conexión.
    */
    class SQLConnection{
        // <--- Método #1: Conexión a "SQL Server". ---> //
        public static SqlConnection getConnection(){
            // Declaración de variables.
            string servidor = "mercadito.axolotlteam.com"; // Ruta de "MySQL" donde se encuentra nuestro servidor.
            // string puerto = "3306"; // Puerto que tiene "MySQL".
            string usuario = "apiManager"; // Usuario de "MySQL".
            string password = "Admin1234"; // Contraseña del host.
            string bd = "AxoloAgenda"; // Nombre de la Base de Datos.

            // Cadena de conexión a "MySQL".
            // string stringConnection = "server=" + servidor + "; port=" + puerto + "; user id=" + usuario + "; password=" + password + "; database=" + bd;
            string stringConnection = "server=" + servidor + "; user id=" + usuario + "; password=" + password + "; database=" + bd;

            /*
               Se genera un objeto de nombre "connection" de la clase "MySqlConnection".
            */
            SqlConnection connection = new SqlConnection(stringConnection);

            return connection; // Retorno de valor.
        }
    }
}
