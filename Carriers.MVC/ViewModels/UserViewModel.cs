using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Carriers.MVC.ViewModels
{
    public class UserViewModel
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Usuário")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres")]
        [DisplayName("Nome Usuário")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Preencha o campo Login")]
        [MaxLength(30, ErrorMessage = "Máximo {0} caracteres")]
        [DisplayName("Login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Preencha o campo Senha")]
        [MaxLength(30, ErrorMessage = "Máximo {0} caracteres")]
        [DisplayName("Senha")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DateRegister { get; set; }
    }
}
