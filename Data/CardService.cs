using System;
using System.Linq;
using System.Threading.Tasks;

namespace eljaroboard.Data
{
    public class CardService
    {
        public Task<Card[]> GetForecastAsync(DateTime startDate)
        {
            // var rng = new Random();
            // return Task.FromResult(Enumerable.Range(1, 5).Select(index => new Card
            // {
            //     Date = startDate.AddDays(index),
            //     TemperatureC = rng.Next(-20, 55),
            //     Summary = Summaries[rng.Next(Summaries.Length)]
            // }).ToArray());
            return null;
        }
    }
}
