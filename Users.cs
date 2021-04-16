using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    /*
      Clase que corresponde a la tabla de "MySQL" de nombre "registro_usuarios".
   */
    class Users
    {
        /*
           Se declaran las variables que corresponden a los campos de la tabla "Activities" de "MySQL Server".
           Se declararon de acuerdo al tipo de dato que corresponden en "MySql Server".
        */
        int usrid, usrRol;
        public string usrName, usrLname, usrUsername, usrEmail, usrPass, usrConPass;

        // Referencias para retornar cada una de las propiedades.
        public int Usrid { get => usrid; set => usrid = value; }
        public int UsrRol { get => usrRol; set => usrRol = value; }
        public string UsrName { get => usrName; set => usrName = value; }
        public string UsrLname { get => usrLname; set => usrLname = value; }
        public string UsrUsername { get => usrUsername; set => usrUsername = value; }
        public string UsrEmail { get => usrEmail; set => usrEmail = value; }
        public string UsrPass { get => usrPass; set => usrPass = value; }
        public string UsrConPass { get => usrConPass; set => usrConPass = value; }
    }
}
