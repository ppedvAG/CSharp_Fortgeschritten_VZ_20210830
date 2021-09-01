using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDataLayer.Entities
{
    public partial class City
    {
        public Guid Id { get; set; }
        public Guid CountryId { get; set; }
        public Guid StateId { get; set; }
        public string Name { get; set; }
        public int? Population { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public bool? CapitolCity { get; set; }
        public bool? StateCapitolCity { get; set; }
        public byte[] CityPicture { get; set; }

        public int GeoNameOrgId { get; set; }

        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
    }
}
