using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    /*
       Esta clase nos ayudará a validar todos aquellos errores posibles que se puedan presentar en los formularios
       que se conectan a la base de datos de "SQL".
    */
    class Control{
        // <---------------------------------------> //
        // <---------- MÉTODOS / METHODS ----------> //
        // <---------------------------------------> //

        // <--- Método #1: Retornar mensajes de error para el formulario de registro. ---> //
        public string ctrlRegister(Users user){ // Recibe como parámetro una variable de tipo "Users".
            Model model = new Model(); // Se crea una instancia de la clase "Model".

            // Declaración de variable de tipo string que almacenará los mensajes de error que correspondan.
            string errorMessage = "";

            // <--- Validación #1: Llenar todos los campos de formulario de registro. ---> //
            // Condición que se activará sí y sólo sí alguno de los campos están vacíos.
            /*
               ".IsNullOrEmpty() verifica que el campo esté vacío o sea "nulo". de ser así, la condición se cumple.
            */
            if (string.IsNullOrEmpty(user.UsrName) || string.IsNullOrEmpty(user.UsrLname) ||
                string.IsNullOrEmpty(user.UsrUsername) || string.IsNullOrEmpty(user.UsrPass) ||
                string.IsNullOrEmpty(user.UsrConPass) || string.IsNullOrEmpty(user.UsrEmail))
                errorMessage = "All fields are required."; // Mensaje de error.

            // <--- Validación #2: Revisión de coincidencia en contraseñas. ---> //
            else{
                // Condición que hace una revisión de las contraseñas, confirmando que coincidan.
                if (user.UsrPass == user.UsrConPass){
                    // Mensaje de error que se mostrará sólo si el nombre de usuario insertado ya existe.
                    if (model.existUser(user.UsrUsername)) errorMessage = "The username already exists. \nPlease choose another one...";
                    else{
                        /*
                          La contraseña insertada por el usuario se encriptará (para eso se llama al método
                          de nombre "Encrypt") y lo asignará a la variable "UsrPass del objeto "user".
                        */
                        user.UsrPass = Encrypt(user.UsrPass);
                        /*
                           Los usuarios que se registren serán solamente "Usuarios", ya que:
                           id 1 = "Administrador".
                           id 2 = "Usuario".
                        */
                        user.UsrRol = 2;

                        /*
                           Se llama al método "registro" mediante un objeto correspondiante a la clase "Model", 
                           al cual se le enviará el objeto "user", ya que, ese objeto contiene todos los datos registrados por el usuario.
                        */
                        model.register(user);
                    }
                }
                else
                    // Mensaje de error que se mostrará si las contraseñas no coinciden.
                    errorMessage = "Passwords do not match. \nPlease try again. =).";
            }
            return errorMessage; // Retorno del mensaje de error.
        }

        // <--- Método #2: Retornar mensajes de error para el formulario de Control de Usuarios (Sólo para administradores). ---> //
        public string ctrlregisterAdmins(Users userAdmin){ // Recibe como parámetro una variable de tipo "Users".
            Model model = new Model(); // Se crea una instancia de la clase "Model".

            // Declaración de variable. Esta almacenará los mensajes de error que correspondan.
            string errorMessage = "";

            // <--- Validación #1: Llenar todos los campos de formulario de registro. ---> //
            // Condición que se activará sí y sólo sí alguno de los campos están vacíos.
            /*
               ".IsNullOrEmpty() verifica que el campo esté vacío o sea "nulo". de ser así, la condición se cumple.
            */
            if (string.IsNullOrEmpty(userAdmin.UsrName) || string.IsNullOrEmpty(userAdmin.UsrLname) || string.IsNullOrEmpty(userAdmin.UsrUsername) || string.IsNullOrEmpty(userAdmin.UsrPass) || string.IsNullOrEmpty(userAdmin.UsrEmail))
                errorMessage = "All fields are required."; // Mensaje de error.

            // <--- Validación #2: Datos no iguales a los predeterminados.
            // Condición que se activará sí y sólo sí alguno de los valores que el administrador intente registrar son los predeterminados de los textboxes.
            else if(userAdmin.UsrName == "NAME" || userAdmin.UsrLname == "LAST NAME" || userAdmin.UsrUsername == "USERNAME" || userAdmin.UsrPass == "PASSWORD" || userAdmin.UsrEmail == "EMAILL")
                    errorMessage = "All fields are required."; // Mensaje de error.
                // <--- Validación #3: Revisión de usuario existente. ---> //
                else{
                    // Mensaje de error que se mostrará sólo si el nombre de usuario insertado ya existe.
                    if (model.existUser(userAdmin.UsrUsername)) errorMessage = "The username already exists. \nPlease choose another one...";
                    else{
                        /*
                            La contraseña insertada por el usuario se encriptará (para eso se llama al método
                            de nombre "Encypt") y lo asignará a la variable "Password1" del objeto "userAdmin".
                        */
                        userAdmin.UsrPass = Encrypt(userAdmin.UsrPass);
                        /*
                            Los usuarios que se registren serán solamente "Administradores", ya que:
                               id 1 = "Administrador".
                               id 2 = "Usuario".
                        */
                        userAdmin.UsrRol = 1;

                        /*
                            Se llama al método "registro" de la clase "model" que se le enviará el objeto "userAdmin",
                            ya que, ese objeto contiene todos los datos registrados por el usuario.
                        */
                        model.register(userAdmin);
                    }
                }
                return errorMessage; // Retorno del mensaje de error.
        }

        // <--- Método #3: Modificación de datos de usuario (Sólo administradores) ---> //
        public string ctrlModifyAdmin(string usrName, string usrLname, string usrUsername, string usrEmail, string usrPass, int usridRol, int usrId){
            Model model = new Model(); // Se crea una instancia de la clase "Model".

            // Declaración de variable. Esta almacenará los mensajes de error que correspondan.
            string errorMessage = "";

            // <--- Validación #1: Llenar todos los campos de formulario de registro. ---> //
            // Condición que se activará sí y sólo sí alguno de los campos están vacíos.
            /*
               ".IsNullOrEmpty() verifica que el campo esté vacío o sea "nulo". de ser así, la condición se cumple.
            */
            if (string.IsNullOrEmpty(usrName) || string.IsNullOrEmpty(usrLname) || string.IsNullOrEmpty(usrUsername) || string.IsNullOrEmpty(usrEmail) || string.IsNullOrEmpty(usrPass) || Convert.ToString(usridRol) == "")
                errorMessage = "All fields are required."; // Mensaje de error.

            // <--- Validación #2: Datos no iguales a los predeterminados.
            // Condición que se activará sí y sólo sí alguno de los valores que el administrador intente modificar son los predeterminados de los textboxes.
            else if (usrName == "NAME" || usrLname == "LAST NAME" || usrUsername == "USERNAME" || usrEmail == "EMAIL" || usrPass == "PASSWORD" || Convert.ToString(usridRol) == "ID_ROL")
                errorMessage = "All fields are required."; // Mensaje de error.
            else
                // Llamada al método "ModifyUsers()".
                model.ModifyUsers(usrName, usrLname, usrUsername, usrEmail, usrPass, usridRol, usrId);

            return errorMessage; // Retorno del mensaje de error.
        }

        // <--- Método #4: Comprobación de datos y contraseñas. ---> //
        public string ctrlUpdateSession(string usrName, string usrLname, string usrUsername, string usrEmail, string usrPass){
            Model model = new Model();

            // Declaración de variable. Esta almacenará los mensajes de error que correspondan.
            string errorMessage = "";

            // <--- Validación #1: Llenar todos los campos de formulario de registro. ---> //
            // Condición que se activará sí y sólo sí alguno de los campos están vacíos.
            /*
               ".IsNullOrEmpty() verifica que el campo esté vacío o sea "nulo". de ser así, la condición se cumple.
            */
            if (usrName == "" || usrLname == "" || usrUsername == ""|| usrEmail == "" || usrPass == "")
                errorMessage = "All fields are required.";

            // <--- Validación #2: Verificar que las contraseñas coincidan. ---> //
            else if (Session.password != usrPass) errorMessage = "Incorrect password. \nPlease try again.";
            else model.updateSessionData(usrName, usrLname, usrUsername, usrEmail);

            return errorMessage;
        }

        // <--- Método #4: Comprobación de usuario existente para el inicio de sesión. ---> //
        public string crtlLogin(string username, string password){ // Recibe como parámetros 2 variables de tipo "string": "usuario" y "password".
            Model model = new Model(); // Se crea una instancia de la clase "Model".

            // Declaración de variable. Esta almacenará los mensajes de error que correspondan.
            string errorMessage = "";
            Users userData = null;

            // <--- Validación #1: Verificar que los campos estén vacíos. ---> //
            // Condición que solo es válida sí y sólo sí el usuario no ha insertado su "username" y "password".
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) errorMessage = "All fields are required."; // Mensaje de error.

            // <--- Validación #2: Traer datos de Sql a mi consulta. ---> //
            else{
                // El dato que se recupere de la base de datos se le asignará a la variable "userData".
                /*
                   Para eso se hace la llamada al método "LoginUser()", que se encarga de hacer las consultas a la
                   tabla "Users" de la base de datos, enviandole como parámetro la variable "username".
                */
                userData = model.LoginUser(username);

                // <--- Validación #3: Usuario no registrado.. ---> //
                // Condición que sólo sea válida sí y sólo sí el usuario no se encuentra o no existe.
                if (userData == null) errorMessage = "The user does not exist."; // Mensaje de error.

                // <--- Validación #3: Usuario registrado. ---> //
                else{
                    /* 
                       Condición que sólo sea válida sí y sólo sí la contraseña registrada en la base de datos (Base 64)
                       es diferente a la contraseña ingresada por el usuario. 
                       Como la contraseña que ingresa el usuario no está en formato "Base 64", se llamará al método "Encrypt"
                       para realizar dicha conversión, permitiendo que el método funcione correctamente.
                    */
                    if (userData.UsrPass != Encrypt(password)) errorMessage = "The user and/or passwords do not match..."; // Mensaje de error.

                    // <--- Validación #4: Datos de usuario que está iniciando sesión. ---> //
                    else{
                        /*
                           Asignación de la propiedad de la clase "registro_usuarios" al objeto "userData"
                           a las variables de la clase "Session".
                        */
                        Session.id = userData.Usrid;
                        Session.name = userData.UsrName;
                        Session.last_name = userData.UsrLname;
                        Session.email = userData.UsrEmail;
                        Session.password = userData.UsrPass;
                        Session.id_tipo = userData.UsrRol;

                        /*
                           A este objeto se le asigna la variable "username" directamente ya que se envía como
                           parámetro al método "ctrlLogin()".
                        */
                        Session.username = username;
                    }
                }
            }
            return errorMessage; // Retorno del mensaje de error.
        }

        // <--- Método #5: Recuperación de contraseña. ---> //
        public string ctrlRecoverPassword(string username, string email){ // Recibe como parámetros 2 variables de tipo "string", que son "username" e "email".
            Model model = new Model(); // Se crea una instancia de la clase "Model".

            // Declaración de variable. Esta almacenará los mensajes de error que correspondan.
            string errorMessage = "";
            Users userData = null;

            // <--- Validación #1: Verificar que los campos estén vacíos. ---> //
            // Condición que solo es válida sí y sólo sí el usuario no ha insertado su "username" y "password".
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email))
                errorMessage = "All fields are required."; // Mensaje de error.

            // <--- Validación #2: Traer datos de Sql a mi consulta. ---> //
            else{
                // El dato que se recupere de la base de datos se le asignará a la variable "userData".
                /*
                   Para eso se hace la llamada al método "RecoverPass()", que se encarga de recuperar la contraseña que
                   se encuentre registrada en la base de datos.
                */
                userData = model.RecoverPass(username);

                // <--- Validación #3: Usuario no registrado.. ---> //
                // Condición que sólo sea válida sí y sólo sí el usuario no se encuentra o no existe.
                if (userData == null) errorMessage = "Sorry, we don't have any users registered with that name."; // Mensaje de error.

                else{
                    // A las propiedades "username" y "password" se les asigna los datos correspondientes.
                    Session.username = username;
                    /*
                       Para la contraseña, se llama al método "Desencypt", debido a que la contraseña que se encuentra registrada
                       en la base de datos, está encriptada.
                    */
                    Session.password = Desencrypt(userData.UsrPass);
                }
            }
            return errorMessage; // Retorno del mensaje de error.
        }

        // <--- Método #6: Método para validaciones de errores en campos obligatorios del feedback. ---> //
        public string ctrlFeedback(string name, string lastName, string email){ // Recibe como parámetros 2 variables de tipo "string", que son "username" e "email".
            // Declaración de variable. Esta almacenará los mensajes de error que correspondan.
            string errorMessage = "";

            // <--- Validación #1: Verificar que los campos estén vacíos. ---> //
            // Condición que solo es válida sí y sólo sí el usuario no ha insertado su "username" y "password".
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email))
                errorMessage = "Main fields are required."; // Mensaje de error.

            return errorMessage; // Retorno del mensaje de error.
        }

        // <--- Método #7: Retornar mensajes de error en el formulario de registro de actividades. ---> //
        public string ctrlActLog(Activities activity){ // Recibe como parámetro una variable del tipo "actividades".
            Model model = new Model(); // Objeto de la clase "Model".

            // Declaración de variable. Esta almacenará los mensajes de error que correspondan.
            string errorMessage = "";

            // <--- Validación #1: Llenar todos los campos de formulario de registro. ---> //
            // Condición que se activará sí y sólo sí alguno de los campos están vacíos.
            /*
               ".IsNullOrEmpty() verifica que el campo esté vacío o sea "nulo". de ser así, la condición se cumple.
            */
            if (string.IsNullOrEmpty(activity.ActName) || string.IsNullOrEmpty(activity.ActType) || string.IsNullOrEmpty(Convert.ToString(activity.ActStart))
                || string.IsNullOrEmpty(Convert.ToString(activity.ActEnd)))

                // <--- Validación #2: Verificar el registro de valores predeterminados ---> //
                // Condición que se activará sí y sólo sí alguno de los campos tienen el texto predeterminado.
                if (activity.ActName == "ACTIVITY NAME" || activity.ActType == "---SELECT---" || Convert.ToString(activity.actStart) == "START"
                    || Convert.ToString(activity.actEnd) == "END") errorMessage = "All fields are required."; // Mensaje de error.
                else{
                    activity.ActUserid = Session.id; // A la propiedad "ActUserid" se le asignará el "Id" del usuario que tiene su sesión iniciada.
                    /*
                      Se llama al método "registro" de la clase "model" que se le enviará el objeto "activity",
                      ya que, ese objeto contiene todos los datos de la actividad registrada.
                    */
                    model.newAct(activity);
                }

            return errorMessage; // Retorno del mensaje de error.
        }

        // <--- Método #8: Encriptar contraseñas. ---> //
        public string Encrypt(string userPassword){ // Recibe como parámetro una variable de tipo "string" de nombre "userPassword".
            byte[] encryted = Encoding.Unicode.GetBytes(userPassword); // Obtiene una matriz de tipo bytes que representa la cadena unicode, dos por cada carácter.
            userPassword = Convert.ToBase64String(encryted); // A la variable cadena se le asigna la matriz enriptada a "Base 64".
            return userPassword; // Retorno de la contraseña encriptada.
        }

        // <--- Método #9: Desencriptar contraseñas. ---> //
        /*
           Este método es muy parecido al "Método #7", lo único distinto es que realiza el proceso inverso de dicho método.
        */
        public string Desencrypt(string encyptPass){ // Recibe como parámetro una variable de tipo "string" de nombre "encyptPass".
            byte[] decryted = Convert.FromBase64String(encyptPass);
            encyptPass = Encoding.Unicode.GetString(decryted);
            return encyptPass; // Retorno de la contraseña desencriptada.
        }
    }
}
