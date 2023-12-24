using Entities.Models;
using Entities.RequestParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contrats
{
    public interface IRickRepository
    {
        IQueryable<RickResult> GetAllRick(bool trackChanges);
        IQueryable<RickResult> GetAllRickDetails(RickParameters r);
        RickResult? GetOneRick(int id, bool trackChanges);
    }
}
