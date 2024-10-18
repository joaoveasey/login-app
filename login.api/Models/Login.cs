using System.ComponentModel.DataAnnotations;

namespace login.api.Models
{
    public class Login
    {
        public string? Username { get; set; }
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
