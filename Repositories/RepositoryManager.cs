using Repositories.Contrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly IRickRepository _rickRepository;

        public RepositoryManager(RepositoryContext context, IRickRepository rickRepository)
        {
            _context = context;
            _rickRepository = rickRepository;
        }

        public IRickRepository RickRepository => _rickRepository;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
