using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCrudDEMO.Model
{
    public class Call
    {
        [Key]
        public int CallID { get; set; }
        [MaxLength(20)]
        public string MobileNumber { get; set; }
    }
}
