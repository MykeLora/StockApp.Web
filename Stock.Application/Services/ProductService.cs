using Stock.Application.Repository;
using Stock.Application.ViewModels;
using Stock.Infraestructure.Context;
using Stock.Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Application.Services
{
    public class ProductService
    {
        private readonly ProductRepository _productRepository;
        public ProductService(ApplicationContext context)
        {
            _productRepository = new(context);
        }


        public async Task Update(SaveProductViewModel vm)
        {
            Product product = new();

            product.Id = vm.Id;
            product.Name = vm.Name;
            product.Description = vm.Description;
            product.Precio = vm.Precio;
            product.PathImage = vm.PathImage;
            product.CategoryId = vm.CategoryId;

            await _productRepository.UpdateAsync(product);
        }

        public async Task Delete(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            await _productRepository.DeleteAsync(product);
        }

        public async Task Save(SaveProductViewModel vm)
        {
            Product product = new ();

            product.Name = vm.Name;
            product.Description = vm.Description;
            product.Precio = vm.Precio;
            product.PathImage = vm.PathImage;
            product.CategoryId = vm.CategoryId;

            await _productRepository.AddAsync(product);
        }

        public async Task<SaveProductViewModel> GetById(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);

            SaveProductViewModel  vm = new();

            vm.Id = product.Id;
            vm.Name = product.Name;
            vm.Description = product.Description;
            vm.Precio = product.Precio;
            vm.PathImage = product.Description;
            vm.CategoryId = product.CategoryId;

            return vm;

        }
        public async Task<List<ProductViewModel>> GetAllViewModel()
        {
            var productList =  await _productRepository.GetAllAsync(); 

            return productList.Select(product => new ProductViewModel
            {
                Name = product.Name,
                Description = product.Description,
                Id = product.Id,
                Precio = product.Precio,
                PathImage = product.PathImage,
                Strock = product.Strock

            }).ToList();
        }
    }

}
