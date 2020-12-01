using System;
using System.ComponentModel.DataAnnotations;
namespace Data
{
    public class CardComment
    {
        public int UserId { get; set; }
        public string Comment { get; set; }
        public DateTime DateEntered { get; set; }

        public CardComment(int userId, string comment)
        {
            UserId = userId;
            Comment = comment;
            DateEntered = DateTime.Now;
        }  
    }
}