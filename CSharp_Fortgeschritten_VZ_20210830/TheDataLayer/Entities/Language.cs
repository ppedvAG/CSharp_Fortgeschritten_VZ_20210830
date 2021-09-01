using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDataLayer.Entities
{
    public partial class Language
    {
        public Language()
        {
            CountryLanguage = new HashSet<CountryLanguage>();
            StateLanguage = new HashSet<StateLanguage>();
        }

        public Guid Id { get; set; }
        public string Language1 { get; set; }

        public virtual ICollection<CountryLanguage> CountryLanguage { get; set; }
        public virtual ICollection<StateLanguage> StateLanguage { get; set; }
    }
}
