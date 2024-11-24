using System.ComponentModel.DataAnnotations;

namespace JeronyCruz_AP1_P2.Models
{
    public class Productos
    {
        [Key]
        public int ArticuloId { get; set; }

        public string? Descripcion { get; set; }

        public double Costo { get; set; }

        public double Precio { get; set; }

        public int Existencia { get; set; }
    }
}
