using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eljaroboard.Data
{
    public class CardService
    {
        public Task<Card[]> GetCards()
        {

            return Task.FromResult(Enumerable.Range(3, 5).Select(index => new Card
            {
                CardId = 0,
                Column = 0,
                CreatorID = 1,
                Downticks = 1,
                Upticks = 3,
                CardText = "Bananatime " + index,
                Comments = new List<CardComment>() {
                    new CardComment { CardCommentId = 0,CardId = 0, Comment = "bullshit in extremis",  DateEntered = DateTime.Now, UserId = 1 },
                    new CardComment { CardCommentId = 0,CardId = 0, Comment = "bullshit in extremis",  DateEntered = DateTime.Now, UserId = 1 },
                    new CardComment { CardCommentId = 0,CardId = 0, Comment = "bullshit in extremis",  DateEntered = DateTime.Now, UserId = 1 }
                }
            }).ToArray());
        }
    }
}
