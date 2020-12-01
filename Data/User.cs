using System.ComponentModel.DataAnnotations;

namespace Data
{
    public class User
    {
        [Required]
        public int UserId { get; set; }
        [StringLength(10, MinimumLength = 6)]
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }
}