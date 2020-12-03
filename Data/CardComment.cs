using System;
using System.ComponentModel.DataAnnotations;
namespace eljaroboard.Data
{
    public class CardComment
    {
        [Key]
        public int CardCommentId { get; set; }
        [Required]
        public int CardId { get; set; }
        [Required]
        public int UserId { get; set; }
        public string Comment { get; set; }
        public DateTime DateEntered { get; set; }
    }
}