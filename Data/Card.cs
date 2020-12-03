using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eljaroboard.Data
{
    public class Card
    {
        [Key]
        public int CardId { get; set; }
        public int Column { get; set; }
        public int CreatorID { get; set; }
        public string CardText { get; set; }
        public int Upticks { get; set; }
        public int Downticks { get; set; }
        public IList<CardComment> Comments { get; set; }
    }
}
