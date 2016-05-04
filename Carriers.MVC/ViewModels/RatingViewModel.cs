
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Carriers.MVC.ViewModels
{
    public class RatingViewModel
    {
        [Key]
        public int RatingId { get; set; }

        [Required(ErrorMessage = "Preencha o campo comentário")]
        [MaxLength(500, ErrorMessage = "Máximo {0} caracteres")]
        [DisplayName("Comentário")]
        public string Comment { get; set; }

        
        [DataType(DataType.Currency)]
        [Range(typeof(int), "0", "10")]
        [Required(ErrorMessage = "Preencha uma nota de classificação")]
        [DisplayName("Nota Classificação")]
        public int Note { get; set; }

        [DisplayName("Disponivel?")]
        public bool Available { get; set; }

        public int CarrierId { get; set; }

        public virtual CarrierViewModel Carrier { get; set; }
    }
}
