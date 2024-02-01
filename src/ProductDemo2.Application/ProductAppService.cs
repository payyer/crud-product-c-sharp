using ProductDemo2.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ProductDemo2
{
    public class ProductAppService : ApplicationService, IProductAppService
    {
        private readonly IRepository<Product, Guid> _productRepository;
        public ProductAppService(IRepository<Product, Guid> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ProductDto> CreateAsync(string name)
        {
            var product = await _productRepository.InsertAsync(new Product { Name = name });
            return new ProductDto() { Id = product.Id , Name = product.Name};
        }

        public async Task DeleteAsync(Guid id)
        {
            await _productRepository.DeleteAsync(id);
        }

        public async Task<ProductDto> GetByIdAsync(Guid id)
        {
            var product = await _productRepository.FindAsync(id);
            var productDto = new ProductDto()
            {
                Id = product.Id,
                Name = product.Name
            };
            return productDto;
        }

        public async Task<List<ProductDto>> GetListAsync()
        {
            var products = await _productRepository.GetListAsync();
            return products.Select(p => new ProductDto() { Id = p.Id, Name = p.Name }).ToList();
        }


        public async Task<ProductDto> UpdateAsync(Guid id, string newName)
        {
            var findProduct = await _productRepository.FindAsync(id);
            if(findProduct != null) 
            {
                findProduct.Name = newName;
            }

            await _productRepository.UpdateAsync(findProduct);

            var updatedProductDto = new ProductDto
            {
                Id = findProduct.Id,
                Name = findProduct.Name,
            };

            return updatedProductDto;
        }
    }
}
