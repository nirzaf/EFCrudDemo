using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCrudDEMO.Model
{
    public class CallDbInititializer : CreateDatabaseIfNotExists<CallContext>
    {
    }
}
