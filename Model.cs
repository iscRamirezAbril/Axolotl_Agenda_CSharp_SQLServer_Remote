﻿// Librerías que nos permitirá conectarnos a la base de datos de "SQL Server".
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

using System;
using System.Collections.Generic;

namespace ProyectoFinal
{
    /*
       Esta clase nos ayudará a realizar todas las insersiones a "SQL Server".
       En otras palabras, esta clase nos va a permitir guardar todos los métodos para las validaciones.
    */
    class Model{
        // <---------------------------------------> //
        // <---------- MÉTODOS / METHODS ----------> //
        // <---------------------------------------> //

        // <--- Método #1: Validación de datos y registro de usuarios ---> //
        public int register(Users user){ // Recibe como parámetro una variable del tipo "Users".
            /*
               Creación de una instancia de la clase "SqlConnection", la cual llamará al método que realiza
               la conexión a "SQL Server".
            */
            SqlConnection connection = SQLConnection.getConnection();
            connection.Open(); // Esta función permite abrir la conexión.

            // Inserción a "SQL Server".
            /*
              "INSERT INTO" se utiliza para "seleccionar" los campos de la tabla "Users"
              donde se insertarán los datos que registre el usuario.
              "VALUES" son los valores que se van a registrar en la tabla de "SQL Server".
            */
            string sql = "INSERT INTO Users (usrName, usrLname, usrUsername, usrEmail, usrPass, usrRol) VALUES (@usrName, @usrLname, @usrUsername, @usrEmail, @usrPass, @usrRol)";

            // Se crea un objeto de la clase "SqlCommand", enviandole como parámetros "sql" y "connection".
            SqlCommand command = new SqlCommand(sql, connection);

            /*
               Se crean "comandos" que realizan la acción de enviar los datos que el ususario registre
               a "SQL", permitiendo así, guardar su información.

               ".AddWithValue() recibe dos parámetros, el primero es el valor que recibirá el comando
               (Valores con "@") y el segundo es el dato que el usuario haya ingresado (un dato de tipo "user"
               con la propiedad de la clase "Users").
            */
            command.Parameters.AddWithValue("@usrName", user.UsrName); // Comando para el campo "usrName".
            command.Parameters.AddWithValue("@usrLname", user.UsrLname); // Comando para el campo "usrLname".
            command.Parameters.AddWithValue("@usrUsername", user.UsrUsername); // Comando para el campo "usrUsername".
            command.Parameters.AddWithValue("@usrEmail", user.UsrEmail); // Comando para el campo "usrEmail".
            command.Parameters.AddWithValue("@usrPass", user.UsrPass); // Comando para el campo "usrPassword".
            command.Parameters.AddWithValue("@usrRol", user.UsrRol); // Comando para el campo "usrRol".

            // Declaración de variables.
            int result = command.ExecuteNonQuery(); // Te devuelve el número de "filas" que se hayan insertado.

            return result; // Retorno de valor.
        }

        // <--- Método #2: Validación de nombres de usuario repetidos al momento de registrar un nuevo usuario. ---> //
        public bool existUser(string username){ // Recibe como parámetro una variable de tipo "string" de nombre "username".
            // Este objeto permite leer todos los datos que se encuentren en la base de datos.
            SqlDataReader reader;

            /*
               Creación de una instancia de la clase "SqlConnection", la cual llamará al método que realiza
               la conexión a "SQL Server".
            */
            SqlConnection connection = SQLConnection.getConnection();
            connection.Open(); // Esta función permite abrir la conexión.

            // Declaración de variable.
            /*
               Esta variable selecciona de la tabla "registro_usuarios" el registro de numero "id"
               cuando en el campo de la base de datos "username" sea igual al parámetros
               que se está registrando.
            */
            string sql = "SELECT usrId FROM Users WHERE usrUsername LIKE @usrUsername";

            // Se crea un objeto de la clase "SqlCommand", enviandole como parámetros "sql" y "connection".
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@usrUsername", username); // Comando para el campo "usrUsername".

            reader = command.ExecuteReader(); // ".ExecuteReader() es el método que permite realizar la lectura de datos.

            /*
               Condición que solo es válida sí y sólo sí el "lector" (reader) encuentra un "username" igual al que
               el actual usuario quiere registrar.
            */
            if (reader.HasRows) return true; // Retorno de valor "true" si un usuario ya está registrado.
            else return false; // Retorno de valor "false" si un usuario no está registrado.
        }

        // <--- Método #3: Validación de nombre de usuario ya existente para el "login" y acceso a la aplicación. ---> //
        /*
          Este método es muy parecido al método "existeUsuario". Las diferencias que tiene este método con el mencionado
          son las siguientes:
          1.- El nombre de este método es "LoginUser".
          2.- Ya no es de tipo "bool", sino de tipo "Users" (clase donde se encuentran las propiedades
              de los campos de la tabla "Users" de "SQL".
          3.- Nueva condición "While()".
        */
        public Users LoginUser(string user){
            // Este objeto permite leer todos los datos que se encuentren en la base de datos.
            SqlDataReader reader;

            /*
               Creación de una instancia de la clase "SqlConnection", la cual llamará al método que realiza
               la conexión a "SQL Server".
            */
            SqlConnection connection = SQLConnection.getConnection();
            connection.Open(); // Esta función permite abrir la conexión.

            // Declaración de variable.
            /*
               Esta variable selecciona de la tabla "Users los siguientes datos de los campos correspondientes:
               1. usrId.    3. usrLname.      5. usrEmail.     7. usrRol.
               2. usrName.  4. usrUsername.   6. usrPass.
               Los selecciona cuando en el campo de la base de datos "usrUsername" sea igual al parámetros que está
               iniciando sesión.
            */
            string sql = "SELECT usrId, usrName, usrLname, usrUsername, usrEmail, usrPass, usrRol FROM Users WHERE usrUsername LIKE @usrUsername";

            // Se crea un objeto de la clase "SqlCommand", enviandole como parámetros "sql" y "connection".
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@usrUsername", user); // Comando para el campo "usrUsername".

            reader = command.ExecuteReader(); // ".ExecuteReader() es el método que permite realizar la lectura de datos.
            Users usr = null; // Declaración de una variable de tipo "registro_usuarios".

            while (reader.Read()){
                // Se crea una instancia de la clase "Users".
                usr = new Users{
                    // Asignación de propiedades.
                    Usrid = Convert.ToInt32(reader["usrId"].ToString()),
                    UsrName = reader["usrName"].ToString(),
                    UsrLname = reader["usrLname"].ToString(),
                    UsrEmail = reader["usrEmail"].ToString(),
                    UsrPass = reader["usrPass"].ToString(),
                    UsrRol = Convert.ToInt32(reader["usrRol"].ToString())
                };
            }
            return usr; // Retorno de los datos acumulados en la variable, correspondientes a la consulta.
        }

        // <--- Método #4: Recuperación de contraseña. ---> //
        /*
           Este método permite recuperar la contraseña de usuario.
        */
        public Users RecoverPass(string usuario){
            // Este objeto permite leer todos los datos que se encuentren en la base de datos.
            SqlDataReader reader;

            /*
               Creación de una instancia de la clase "SqlConnection", la cual llamará al método que realiza
               la conexión a "SQL Server".
            */
            SqlConnection connection = SQLConnection.getConnection();
            connection.Open(); // Esta función permite abrir la conexión.

            // Declaración de variable.
            /*
               Esta variable selecciona de la tabla "Users" los siguientes datos de los campos correspondientes:
               1. usrUsername.
               Los selecciona cuando en el campo de la base de datos "usrUsername" sea igual al parámetros que está
               tratando de recuperar su contraseña.
            */
            string sql = "SELECT usrId, usrUsername, usrPass FROM Users WHERE usrUsername LIKE @usrUsername"; ;

            // Se crea un objeto de la clase "SqlCommand", enviandole como parámetros "sql" y "connection".
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@usrUsername", usuario); // Comando para el campo "usrUsername".

            reader = command.ExecuteReader(); // ".ExecuteReader() es el método que permite realizar la lectura de datos.
            Users usr = null; // Declaración de una variable de tipo "Users".

            while (reader.Read()){
                // Se crea una instancia de la clase "Users".
                usr = new Users{
                    // Asignación de propiedades.
                    UsrUsername = reader["usrUsername"].ToString(),
                    UsrPass = reader["usrPass"].ToString()
                };
            }

            return usr; // Retorno de los datos acumulados en la variable, correspondientes a la consulta.
        }

        // <--- Método #5: Modificación de datos de usuario (sólo administradores). ---> //
        public int ModifyUsers(string Usrname, string UsrLname, string UsrUsername, string UsrEmail, string UsrPass, int UsridRol, int Usrid){
            // Inserción a "SQL".
            /*
               Esta variable selecciona de la tabla "Users" los siguientes datos de los campos correspondientes:
               1. usrName.       3. usrUsername.  5. usrId.    7. usrRol
               2. ustLname.      4. usrEmail.     6. usrPass.
               Seleccina esos campos para tener acceso a ellos y poder actualizarlos.
            */
            string sql = "UPDATE Users SET usrName='" + Usrname + "', usrLname='" + UsrLname + "', usrUsername='" + UsrUsername + "', usrEmail='" + UsrEmail + "', usrPass='" + UsrPass + "', usrRol='" + UsridRol + "' WHERE usrId='" + Usrid + "'";

            /*
               Creación de una instancia de la clase "SqlConnection", la cual llamará al método que realiza
               la conexión a "SQL Server".
            */
            SqlConnection connection = SQLConnection.getConnection();
            connection.Open();  // Esta función permite abrir la conexión.

            // Se crea un objeto de la clase "SqlCommand", enviandole como parámetros "sql" y "connection".
            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery(); // Devuelve el número de usuarios actualizados.

            return result; // Retorno del total de campos modificados.
        }

        // <--- Método #7: Actualización de datos de usuario que tiene una sesión abierta. ---> //
        public int updateSessionData(string Usrname, string UsrLname, string UsrUsername, string UsrEmail){
            // Inserción a "SQL".
            /*
               Esta variable selecciona de la tabla "Users" los siguientes datos de los campos correspondientes:
               1. usrName.       3. usrUsername.  5. usrId.
               2. ustLname.      4. usrEmail.
               Seleccina esos campos para tener acceso a ellos y poder actualizarlos.
            */
            string sql = "UPDATE Users SET usrName='" + Usrname + "', usrLname='" + UsrLname + "', usrUsername='" + UsrUsername + "', usrEmail='" + UsrEmail + "' WHERE usrId='" + Session.id + "'";

            /*
               Creación de una instancia de la clase "SqlConnection", la cual llamará al método que realiza
               la conexión a "SQL Server".
           */
            SqlConnection connection = SQLConnection.getConnection();
            connection.Open();  // Esta función permite abrir la conexión.

            // Se crea un objeto de la clase "SqlCommand", enviandole como parámetros "sql" y "connection".
            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery(); // Devuelve el número de usuarios actualizados.

            return result; // Retorno del total de campos modificados.
        }

        // <--- Método #6: Eliminar cuenta de usuario. ---> //
        public int DeleteAccount(int Usrid){
            // Inserción a "SQL".
            /*
               Esta variable selecciona de la tabla "Users" los siguientes datos de los campos correspondientes:
               1. usrId.
               Seleccina esos campos para tener acceso a ellos y eliminar el usuario de dicho id.
            */
            string sql = "DELETE Users WHERE usrId='" + Usrid + "'";

            /*
               Creación de una instancia de la clase "SqlConnection", la cual llamará al método que realiza
               la conexión a "SQL Server".
            */
            SqlConnection connection = SQLConnection.getConnection();
            connection.Open();  // Esta función permite abrir la conexión.

            // Se crea un objeto de la clase "SqlCommand", enviandole como parámetros "sql" y "connection".
            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery(); // Devuelve el número de usuarios actualizados.

            return result; // Retorno del total de campos modificados.
        }

        // <--- Método #5: Eliminar una actividad. ---> //
        public int DeleteAct(string ActName){
            // Inserción a "SQL".
            /*
               Esta variable selecciona de la tabla "Activities" los siguientes datos de los campos correspondientes:
               1. ActName.
               Seleccina esos campos para tener acceso a ellos y eliminar la actividad de dicho nombre.
            */
            string sql = "DELETE FROM Activities WHERE actName= '" + ActName + "'";

            /*
               Creación de una instancia de la clase "SqlConnection", la cual llamará al método que realiza
               la conexión a "SQL Server".
            */
            SqlConnection connection = SQLConnection.getConnection();
            connection.Open();  // Esta función permite abrir la conexión.

            // Se crea un objeto de la clase "MySqlCommand", enviandole como parámetros "sql" y "connection".
            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery(); // Devuelve el número de usuarios actualizados.

            return result; // Retorno del total de campos modificados.
        }

        // <--- Método #6: Validación de datos y registro de actividades. ---> //
        public int newAct(Activities activity){ // Recibe como parámetro una variable de tipo "Activities".
            /*
               Creación de una instancia de la clase "SqlConnection", la cual llamará al método que realiza
               la conexión a "SQL Server".
            */
            SqlConnection connection = SQLConnection.getConnection();
            connection.Open(); // Esta función permite abrir la conexión.

            // Inserción a "SQL".
            /*
              "INSERT INTO" se utiliza para "seleccionar" los campos de la tabla "Activities"
              donde se insertarán los datos que registre el usuario.
              "VALUES" son los valores que se van a registrar en la tabla de "SQL".
            */
            string sql = "INSERT INTO Activities (actName, actType, actStart, actEND, actUserid) VALUES (@actName, @actType, @actStart, @actEnd, @actUserid)";

            // Se crea un objeto de la clase "SqlCommand", enviandole como parámetros "sql" y "connection".
            SqlCommand command = new SqlCommand(sql, connection);

            /*
               Se crean "comandos" que realizan la acción de enviar los datos que el ususario registre
               a "SQL", permitiendo así, guardar su información.

               ".AddWithValue() recibe dos parámetros, el primero es el valor que recibirá el comando
               (Valores con "@") y el segundo es el dato que el usuario haya ingresado (un dato de tipo "activity"
               con la propiedad de la clase "Activities").
            */
            command.Parameters.AddWithValue("@actName", activity.ActName); // Comando para el campo "ctName".
            command.Parameters.AddWithValue("@actType", activity.ActType); // Comando para el campo "actType".
            command.Parameters.AddWithValue("@actStart", activity.ActStart); // Comando para el campo "actStart".
            command.Parameters.AddWithValue("@actEnd", activity.ActEnd); // Comando para el campo "actEnd".
            command.Parameters.AddWithValue("@actUserid", activity.ActUserid); // Comando para el campo "actUserid".

            // Declaración de variables.
            int result = command.ExecuteNonQuery(); // Te devuelve el número de "filas" que se hayan insertado.

            return result; // Retorno de valor.
        }

        // <--- Método #7: Asignación de los usuarios registrados a una lista ---> //
        public List<Object> userQuery(string data){
            // Este objeto permite leer todos los datos que se encuentren en la base de datos.
            SqlDataReader reader;
            // Creación d eun objeto de la clase "Lista<object>".
            List<object> List = new List<object>();
            // Inserción a Sql.
            string sql;

            // Condición que sólo es válida sí y sólo la tabla se carga por primera vez.
            if (data == null)
                // Inserción.
                sql = "SELECT usrId, usrName, usrLname, usrUsername, usrEmail, usrPass, usrRol FROM Users ORDER BY usrUsername ASC";
            // Condición que permitirá visualizar los datos registrados.
            else
                // Inserción.
                sql = "SELECT usrId, usrName, usrLname, usrUsername, usrEmail, usrPass, usrRol FROM Users WHERE usrId LIKE '%" + data + "%' OR usrName LIKE '%" + data + "%' OR usrLname LIKE '%" + data + "%' OR usrUsername LIKE '%" + data + "%' OR usrEmail LIKE '%" + data + "%' OR usrPass LIKE '%" + data + "%' OR usrRol LIKE '%" + data + "%' ORDER BY usrUsername ASC";

            try{
                SqlConnection connection = SQLConnection.getConnection();
                connection.Open(); // Esta función permite abrir la conexión.

                // Se crea un objeto de la clase "SqlCommand", enviandole como parámetros "sql" y "connection".
                SqlCommand command = new SqlCommand(sql, connection);

                reader = command.ExecuteReader(); // ".ExecuteReader() es el método que permite realizar la lectura de datos.

                while (reader.Read()){
                    // Creación de un objeto de la clase "Users".
                    Users User = new Users{
                        // Asignación de propiedades.
                        Usrid = (int)reader[0],
                        UsrName = reader[1].ToString(),
                        UsrLname = reader[2].ToString(),
                        UsrUsername = reader[3].ToString(),
                        UsrEmail = reader[4].ToString(),
                        UsrPass = reader[5].ToString(),
                        UsrRol = (int)reader[6]
                    };

                    List.Add(User); // Los datos que se leyeron se agregarán a la lista.
                }
            }
            // "catch" que sólo se activará si se presenta algún tipo de excepción de MySql.
            catch (MySqlException ex){
                Console.WriteLine(ex.Message.ToString()); // Mensaje de error.
            }

            return List; // Retorno de la lista.
        }

        // <--- Método #8: Asignación de las actividades registradas en la base de datos a una lista ---> //
        public List<object> ActQuery(string act){
            // Este objeto permite leer todos los datos que se encuentren en la base de datos.
            SqlDataReader reader;
            // Creación d eun objeto de la clase "Lista<Object>".
            List<object> List = new List<object>();
            // Variable para inserción a Sql.
            string sql;

            /*
               La inserción a "SQL" es la siguiente:
               De la tabla "Activities" se seleccionan dichos campos, en donde el "usrId" sea igual al "id" 
               del usuario que tiene la sesión activa.
            */
            if (act == null) sql = "SELECT actId, actName, actType, actStart, actEND, actUserid FROM Activities WHERE actUserid LIKE '" + Session.id + "'";
            else sql = "SELECT actId, actName, actType, actStart, actEND, actUserid FROM Activities WHERE actUserid LIKE '" + Session.id + "'";

            try{
                SqlConnection connection = SQLConnection.getConnection();
                connection.Open(); // Esta función permite abrir la conexión.

                // Se crea un objeto de la clase "MySqlCommand", enviandole como parámetros "sql" y "conexion".
                SqlCommand command = new SqlCommand(sql, connection);

                reader = command.ExecuteReader(); // ".ExecuteReader() es el método que permite realizar la lectura de datos.

                while (reader.Read()){
                    // Creación de un objeto de la clase "Activities".
                    Activities Activity = new Activities{
                        // Asignación de propiedades.
                        ActId = (int)reader[0],
                        ActName = reader[1].ToString(),
                        ActType = reader[2].ToString(),
                        ActStart = (DateTime)reader[3],
                        ActEnd = (DateTime)reader[4],
                        ActUserid = (int)reader[5]
                    };

                    List.Add(Activity); // Los datos que se leyeron se agregarán a la lista.
                }
            }
            // "catch" que sólo se activará si se presenta algún tipo de excepción de MySql.
            catch (MySqlException ex){
                Console.WriteLine(ex.Message.ToString()); // Mensaje de error.
            }

            return List; // Retorno de la lista.
        }
    }
}
