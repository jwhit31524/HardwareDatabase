using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectingToHWDatabase.database
{
    public class HWContext : DbContext
    {
        public DbSet<HWEntity> HWEntities { get; set; }
        public HWContext() : base("name=TheHWDatabase") { }
    }
}
