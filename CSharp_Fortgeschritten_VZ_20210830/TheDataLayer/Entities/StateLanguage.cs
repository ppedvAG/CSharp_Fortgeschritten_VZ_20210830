using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDataLayer.Entities
{
    public partial class StateLanguage
    {
        public Guid Id { get; set; }
        public Guid? CountryId { get; set; }
        public Guid? StateId { get; set; }
        public Guid? LanguageId { get; set; }
        public double? Percent { get; set; }

        public virtual Country Country { get; set; }
        public virtual Language Language { get; set; }
        public virtual State State { get; set; }
    }
}
