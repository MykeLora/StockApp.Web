using Stock.Infraestructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Infraestructure.Models
{
    public class Product : BaseModel
    {
        public string? PathImage {  get; set; }
        public double Precio {  get; set; }
        public int Strock {  get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
