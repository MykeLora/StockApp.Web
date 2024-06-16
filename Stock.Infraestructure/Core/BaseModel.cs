using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Infraestructure.Core
{
    public abstract class BaseModel
    {
        public virtual int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
