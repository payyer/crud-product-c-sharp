using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace ProductDemo2.Products
{
    public interface IProductAppService : IApplicationService
    {
        Task<List<ProductDto>> GetListAsync();
        Task<ProductDto> GetByIdAsync(Guid id);
        Task<ProductDto> CreateAsync(string name);
        Task DeleteAsync(Guid id);
        Task<ProductDto> UpdateAsync(Guid id, string newName);
    }
}
