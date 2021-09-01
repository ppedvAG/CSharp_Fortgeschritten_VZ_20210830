using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDataLayer.Entities
{
    public partial class State
    {
        public State()
        {
            City = new HashSet<City>();
            StateLanguage = new HashSet<StateLanguage>();
        }

        public Guid Id { get; set; }
        public Guid CountryId { get; set; }
        public string Name { get; set; }
        public int? Population { get; set; }
        public byte[] Flag { get; set; }

        public int GeoNameOrgId { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<City> City { get; set; }
        public virtual ICollection<StateLanguage> StateLanguage { get; set; }
    }
}
