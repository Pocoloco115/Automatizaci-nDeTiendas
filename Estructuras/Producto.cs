using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizaciónDeTiendas.Estructuras
{
    public class Producto
    {
        public int ProductoID { get; set; } 
        public string NombreProducto { get; set; }
        public int CantidadDisponible { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaExpiracion { get; set; }
        public int NivelStockMinimo { get; set; }
        public List<AlertaInventario> Alertas { get; set; }

        public Producto()
        {
            Alertas = new List<AlertaInventario>();
        }
    }

}
