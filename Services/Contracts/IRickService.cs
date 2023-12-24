using Entities.Models;
using Entities.RequestParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IRickService
    {
        IEnumerable<RickResult> GetAllRick(bool trackChanges);
        IEnumerable<RickResult> GetAllRickDetails(RickParameters r);
        RickResult? GetOneRick(int id, bool trackChanges);
    }
}
