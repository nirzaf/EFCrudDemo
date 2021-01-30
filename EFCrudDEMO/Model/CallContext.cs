using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCrudDEMO.Model
{
    public class CallContext : DbContext
    {
        public CallContext() : base("name=con")
        {
            Database.SetInitializer(new CallDbInititializer());
        }

        public DbSet<Call> Calls { get; set; }

    }
}
