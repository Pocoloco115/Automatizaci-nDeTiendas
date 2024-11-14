using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizaciónDeTiendas.Estructuras
{
    public class Cliente
    {
        public int ClienteID { get; set; } 
        public string Nombre { get; set; }
        public int FrecuenciaCompras { get; set; }
        public string ProductosPreferidos { get; set; }
        public string HistorialCompras { get; set; }

        public List<Factura> Facturas { get; set; }

        public Cliente()
        {
            Facturas = new List<Factura>();
        }
    }
}
