using System.Collections.Generic;
using System.Linq;

namespace Tyuiu.GetsMA.Sprint7.Project.V4.Lib
{
    public class StatisticService_GMA
    {
        public int GetCount(List<Book_GMA> books) => books.Count;

        public decimal GetAveragePrice(List<Book_GMA> books)
            => books.Average(b => b.Price_GMA);

        public decimal GetMinPrice(List<Book_GMA> books)
            => books.Min(b => b.Price_GMA);

        public decimal GetMaxPrice(List<Book_GMA> books)
            => books.Max(b => b.Price_GMA);
    }
}
