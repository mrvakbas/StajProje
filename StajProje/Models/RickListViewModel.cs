using Entities.Models;

namespace StajProje.Models
{
    public class RickListViewModel
    {
        public IEnumerable<RickResult> RickResult { get; set; } = Enumerable.Empty<RickResult>();
        public Pagination Pagination { get; set; } = new();
        public int TotalCount => RickResult.Count();
    }
}
