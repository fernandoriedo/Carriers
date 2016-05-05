
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Carriers.MVC.ViewModels
{
    public class CarrierViewModel
    {
        [Key]
        public int CarrierId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Nome da transportadora")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Preencha o campo Endereço")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Endereço")]
        public string Address { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Preencha o campo Sobrenome")]
        [MaxLength(20, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(5, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Telefone")]
        public string PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Preencha o campo Email")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DateRegister { get; set; }

        [DisplayName("Ativo")]
        public bool Active { get; set; }

        public virtual IEnumerable<RatingViewModel> Ratings { get; set; }
    }
}
