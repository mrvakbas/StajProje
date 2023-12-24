using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.RequestParameters
{
    public class RickParameters : RequestParameters
    {

        public int Id { get; set; }
        public string Name { get; set; } 
        public string AirDate { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public RickParameters() : this(1, 4)
        {

        }

        public RickParameters(int pageNumber = 1, int pageSize = 4)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }
}
