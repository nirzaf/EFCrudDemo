using EFCrudDEMO.Model;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCrudDEMO.DAL
{
    public class CallRepo
    {
        public void Create(Call call)
        {
            using (CallContext db = new CallContext())
            {
                db.Set<Call>().Attach(call);
                db.Entry(call).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Update(int Id)
        {
            using (CallContext db = new CallContext())
            {
                var callLogs = db.Calls.FirstOrDefault(c => c.CallID == Id);
                if (callLogs != null)
                {
                    db.Set<Call>().Attach(callLogs);
                    db.Entry(callLogs).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }


        public void Delete(int Id)
        {
            using (CallContext db = new CallContext())
            {
                var callLogs = db.Calls.FirstOrDefault(c => c.CallID == Id);
                db.Set<Call>().Attach(callLogs);
                db.Entry(callLogs).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public List<Call> View()
        {
            using (CallContext callCont = new CallContext())
            {
                var data = callCont.Calls.ToList();
                return data;
            }
        }
    }
}
