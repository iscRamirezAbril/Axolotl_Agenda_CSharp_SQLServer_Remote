using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    /*
       Clase que corresponde a la tabla de "MySQL" de nombre "Activities".
    */
    public class Activities{
        /*
           Se declaran las variables que corresponden a los campos de la tabla "Activities" de "MySQL Server".
           Se declararon de acuerdo al tipo de dato que corresponden en "MySql Server".
        */
        int actId, actUserid;
        public string actName, actType;
        public DateTime actStart, actEnd;

        // Referencias para retornar cada una de las propiedades.
        public int ActId { get => actId; set => actId = value; }
        public int ActUserid { get => actUserid; set => actUserid = value; }
        public string ActName { get => actName; set => actName = value; }
        public string ActType { get => actType; set => actType = value; }
        public DateTime ActStart { get => actStart; set => actStart = value; }
        public DateTime ActEnd { get => actEnd; set => actEnd = value; }
    }
}
