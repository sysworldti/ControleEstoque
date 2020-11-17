using System.ComponentModel.DataAnnotations;

namespace ControleEstoque.MVC.Models
{    
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Display(Description = "Login do Usuário")]
        [MaxLength(length: 100, ErrorMessage = "Não respeitou o tamanho permitido para o seu login")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo e-mail deve ser preenchido")]
        public string Email { get; set; }

        [Display(Description = "Senha do Usuário")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "O campo de senha deve ser preenchido")]
        public string Password { get; set; }

        [Display(Description = "Indica se o usuário está ativo no sistema")]
        public bool IsActive { get; set; }
    }
}