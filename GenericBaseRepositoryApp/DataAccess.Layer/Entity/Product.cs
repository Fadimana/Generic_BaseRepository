using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Layer.Entity
{
    public class Product :BaseEntity
    {
        public int Amount { get; set; }
        public int UnitPrice { get; set; }
    }
}
