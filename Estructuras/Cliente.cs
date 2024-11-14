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
        public string Password { get; set; }
        public int FrecuenciaCompras { get; set; }
        public string ProductosPreferidos { get; set; }
        public string HistorialCompras { get; set; }

        public List<Factura> Facturas { get; set; }

        public Cliente(int ClienteID, string Nombre, string Password)
        {
            this.ClienteID = ClienteID;
            this.Nombre = Nombre;
            this.Password = Password;
            Facturas = new List<Factura>();
        }
    }
}
