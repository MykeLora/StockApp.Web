using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Application.ViewModels
{
    public class SaveProductViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debes colocar el nombre del producto")]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? PathImage { get; set; }
        [Required(ErrorMessage = "Debes colocar el precio del producto")]
        public double Precio { get; set; }

        [Required(ErrorMessage = "Debes colocar la categoria del producto")]
        public int CategoryId { get; set; }

    }
}
