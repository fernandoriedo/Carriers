
using System;
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

        
        [Range(typeof(int), "0", "10")]
        [Required(ErrorMessage = "Preencha uma nota de classificação")]
        [DisplayName("Nota Classificação")]
        public int Note { get; set; }

        [DisplayName("Disponivel?")]
        public bool Available { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DateRegister { get; set; }

        public int CarrierId { get; set; }

        public virtual CarrierViewModel Carrier { get; set; }

        public int UserId { get; set; }

        public virtual UserViewModel User { get; set; }

    }
}
