using Microsoft.AspNetCore.Mvc;
using Stock.Application.Services;
using Stock.Application.ViewModels;
using Stock.Infraestructure.Context;

namespace StockApp.Web.Controllers
{
    public class ProductController : Controller
    {

        private readonly ProductService _productService;

        public ProductController(ApplicationContext context)
        { 
            _productService = new(context);
        }
        public async Task<IActionResult> Index()
        {
            return View(await _productService.GetAllViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Create(SaveProductViewModel vm)
        {

            if(!ModelState.IsValid)
            {
                return View("SaveProduct", vm);
            }

            await _productService.Save(vm);
            return RedirectToRoute(new { controller = "Product", action = "Index" });
        }

        public async Task<IActionResult> Edit( int id)
        {
            return View("SaveProduct", await _productService.GetById(id));
        }

        [HttpPost]
        public  async Task<IActionResult> Edit(SaveProductViewModel vm)
        {

            if (!ModelState.IsValid)
            {
                return View("SaveProduct", vm);
            }

            await _productService.Update(vm);
            return RedirectToRoute(new { controller = "Product", action = "Index" });
        }

        public async Task<IActionResult> Delete(int id)
        {
            return View(await _productService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> DeletePost(int id)
        {

            await _productService.Delete(id);
            return RedirectToRoute(new { controller = "Product", action = "Index" });
        }
    }
}
