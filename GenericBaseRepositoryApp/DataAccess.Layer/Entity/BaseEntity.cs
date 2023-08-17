using DataAccess.Layer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Layer.Entity
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
