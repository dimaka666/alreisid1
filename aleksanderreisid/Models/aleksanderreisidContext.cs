using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace aleksanderreisid.Models
{
    public class aleksanderreisidContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public aleksanderreisidContext() : base("name=aleksanderreisidContext")
        {
        }

        public System.Data.Entity.DbSet<aleksanderreisid.Models.Content> Contents { get; set; }
        public System.Data.Entity.DbSet<aleksanderreisid.Models.Citytrip> citytrips { get; set; }  
        public System.Data.Entity.DbSet<aleksanderreisid.Models.City> cities { get; set; } 
        public System.Data.Entity.DbSet<aleksanderreisid.Models.Trip> trips { get; set; }


    
    }
}
