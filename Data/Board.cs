using System;
using System.ComponentModel.DataAnnotations;

namespace eljaroboard.Data
{
    public class Board
    {
        [Key]
        public int BoardId { get; set; }
        [Required]
        public DateTime RetroDate { get; set; }
        [Required]
        public string RetroName { get; set; }
    }
}