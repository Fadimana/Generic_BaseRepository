using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Layer.Entity
{
    public class Customer :BaseEntity
    {
        [StringLength(1)]
        public string? Gender { get; set; }

        [StringLength(11)]
        public string? TelNo { get; set; }
       

    }
}
