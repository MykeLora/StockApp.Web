using Stock.Infraestructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Infraestructure.Models
{
    public class Category : BaseModel
    {
       public ICollection<Product>? Products { get; set; }

    }
}
