using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JeronyCruz_AP1_P2.Models
{
    public class CombosDetalle
    {
        [Key]
        public int DetalleId { get; set; }

        [ForeignKey("Combos")]
        public int ComboId { get; set; }
        public Combos? Combos { get; set; }

        [ForeignKey("Articulos")]
        public int ArticuloId { get; set; }
        public Productos? Articulos { get; set; }

        [Required(ErrorMessage = "Por favor ingrese el precio del Combo")]
        [RegularExpression(@"^\d+(\.\d+)?$", ErrorMessage = "Solo se permiten números enteros o decimales")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "Por favor ingrese el precio del Combo")]
        [RegularExpression(@"^\d+(\.\d+)?$", ErrorMessage = "Solo se permiten números enteros o decimales")]
        public double Costo { get; set; }

        
    }
}
