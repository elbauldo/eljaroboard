using System.ComponentModel.DataAnnotations;

namespace eljaroboard.Data
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [StringLength(10, MinimumLength = 6)]
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }
}