using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    /*
       Esta clase sirve como "memoria caché", lo que significa que, los datos del usuario
       que inicia sesión se quedan guardados en dicha memoria.
    */
    public class Session{
        // Declaración de variables que serán utilizadas como propiedades.
        public static int id, id_tipo;
        public static string name, last_name, username, email, password;
    }
}
