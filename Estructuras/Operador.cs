using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizaciónDeTiendas.Estructuras
{
    public class Operador
    {
        public int OperadorID { get; set; } 
        public string NombreOperador { get; set; }
        public string Password { get; set;}
    }

    public static class OperadoresPredefinidos
    {
        public static List<Operador> ObtenerOperadores()
        {
            return new List<Operador>
            {
                new Operador { OperadorID = 1, NombreOperador = "William", Password = "nigga2" },
                new Operador { OperadorID = 2, NombreOperador = "Walter", Password = "nigga" }
            };
        }
    }
}
