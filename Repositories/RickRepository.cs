using Entities.Models;
using Entities.RequestParameters;
using Microsoft.EntityFrameworkCore;
using Repositories.Contrats;
using Repositories.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class RickRepository : RepositoryBase<RickResult>, IRickRepository
    {
        public RickRepository(RepositoryContext context) : base(context)
        {
        }


        public IQueryable<RickResult> GetAllRick(bool trackChanges) => FindAll(trackChanges);


        public IQueryable<RickResult> GetAllRickDetails(RickParameters r)
        {
            return _context
                .RickResults
                .FilteredByDate(r.AirDate)
                .FilteredBySearchTerm(r.SearchTerm)
                .ToPaginate(r.PageNumber, r.PageSize);
        }

        public RickResult? GetOneRick(int id, bool trackChanges)
        {
            return FindByCondition(p => p.Id.Equals(id), trackChanges);
        }
    }
}
