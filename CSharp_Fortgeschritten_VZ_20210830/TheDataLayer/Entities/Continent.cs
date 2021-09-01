using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDataLayer.Entities
{
    public partial class Continent
    {
        public Continent()
        {
            Country = new HashSet<Country>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public int GeoNameOrgId { get; set; }

        public virtual ICollection<Country> Country { get; set; }
    }
}
