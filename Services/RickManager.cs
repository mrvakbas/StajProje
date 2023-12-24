using Entities.Models;
using Entities.RequestParameters;
using Repositories.Contrats;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class RickManager : IRickService
    {
        private readonly IRepositoryManager _manager;

        public RickManager(IRepositoryManager manager)
        {
            _manager = manager;
        }


        public IEnumerable<RickResult> GetAllRick(bool trackChanges)
        {
            return _manager.RickRepository.GetAllRick(trackChanges);
        }

        public IEnumerable<RickResult> GetAllRickDetails(RickParameters r)
        {
            return _manager.RickRepository.GetAllRickDetails(r);
        }

        public RickResult? GetOneRick(int id, bool trackChanges)
        {
            var rick = _manager.RickRepository.GetOneRick(id, trackChanges);
            if (rick is null)
                throw new Exception("rick not found");
            return rick;
        }
    }
}
