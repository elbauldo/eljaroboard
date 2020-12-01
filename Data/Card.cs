using System;
using System.ComponentModel.DataAnnotations;

namespace eljaroboard.Data
{
    public class Card
    {
        [Key]
        public int CardId { get; set; }
        public DateTime Created { get; set; }
        public int CreatorID { get; set; }
        public int Upticks { get; set; }
        public int Downticks { get; set; }
    }
}
