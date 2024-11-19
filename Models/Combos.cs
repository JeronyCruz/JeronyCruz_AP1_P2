using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JeronyCruz_AP1_P2.Models
{
    public class Combos
    {
        [Key]
        public int ComboId { get; set; }

        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "Por favor ingrese la Descripcion del Combo")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Por favor ingrese el precio del Combo")]
        [RegularExpression(@"^\d+(\.\d+)?$", ErrorMessage = "Solo se permiten números enteros o decimales")]
        public double Precio { get; set; }

        public bool Vendindo { get; set; }

        [ForeignKey("ComboId")]
        public ICollection<CombosDetalle> CombosDetalles { get; set;} = new List<CombosDetalle>();
    }
}
