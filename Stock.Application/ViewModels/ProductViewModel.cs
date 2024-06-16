using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Application.ViewModels
{
    public class ProductViewModel
    {
        public  int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? PathImage { get; set; }
        public double Precio { get; set; }
        public int Strock { get; set; }
    }
}
