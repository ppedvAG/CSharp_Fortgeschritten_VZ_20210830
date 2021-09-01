using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDataLayer.Context
{
    public static class DbContextFactory
    {
        private static GeoDBContext geoDBContext = null;

        static DbContextFactory()
        {
            var optionsBuilder = new DbContextOptionsBuilder<GeoDBContext>();
            optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=GeoDB;Integrated Security=true;");

            geoDBContext = new GeoDBContext(optionsBuilder.Options);
        }

        public static GeoDBContext GeoDBContextInstance
        {
            get { return geoDBContext; }
        }
    }
}
