using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IRickService _rickService;

        public ServiceManager(IRickService rickService)
        {
            _rickService = rickService;
        }

        public IRickService RickService => _rickService;
    }
}
