using System.ComponentModel.DataAnnotations;

namespace login.api.Models
{
    public class Register
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "O seu usuário deve ter no máximo 20 caracteres.")]
        public string? Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

    }
}
