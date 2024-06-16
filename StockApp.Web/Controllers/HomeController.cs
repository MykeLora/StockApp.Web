using Microsoft.AspNetCore.Mvc;
using Stock.Application.Services;
using Stock.Infraestructure.Context;
using StockApp.Web.Models;
using System.Diagnostics;

namespace StockApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductService _productService;

        public HomeController(ApplicationContext dbContext)
        {
            _productService = new(dbContext);
        }

        public  async Task<IActionResult> Index()
        { 
            return View(await _productService.GetAllViewModel());
        }

    }
}
