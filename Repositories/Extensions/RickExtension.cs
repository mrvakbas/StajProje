using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Extensions
{
    public static class RickExtension
    {
        public static IQueryable<RickResult> FilteredBySearchTerm(this IQueryable<RickResult> rick,
            String? searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return rick;
            else
                return rick.Where(prd => prd.Name.ToLower()
                .Contains(searchTerm.ToLower()));
        }
        public static IQueryable<RickResult> FilteredByDate(this IQueryable<RickResult> rick,
            String? search)
        {
            if (string.IsNullOrWhiteSpace(search))
                return rick;
            else
                return rick.Where(prd => prd.AirDate.ToLower()
                .Contains(search.ToLower()));
        }


        public static IQueryable<RickResult> ToPaginate(this IQueryable<RickResult> rick,
            int pageNumber, int pageSize)
        {
            return rick
                .Skip(((pageNumber - 1) * pageSize))
                .Take(pageSize);
        }
    }
}
