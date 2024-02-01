using Microsoft.AspNetCore.Components;
using ProductDemo2.Products;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductDemo2.Blazor.Pages;

public partial class Index
{
    [Inject]
    private IProductAppService ProductAppService { get; set; }
    private List<ProductDto> Products { get; set; }
    private string NewProduct {  get; set; }
    public Guid idProduct { get; set; }
    protected override async Task OnInitializedAsync()
    {
        Products = await ProductAppService.GetListAsync();
    }

    private async Task Create()
    {
        var result = await ProductAppService.CreateAsync(name: NewProduct);
        Products.Add(result);
        NewProduct = "";
    }
    private async Task Delete(ProductDto product)
    {
        await ProductAppService.DeleteAsync(id: product.Id);
        Products.Remove(product);
        await Notify.Info("Xóa thành công!");
    }

    private async Task<ProductDto> GetById(Guid id)
    {
        var product  = await ProductAppService.GetByIdAsync(id);
        return product;
    }

    public void GetItemProductToUpdate(Guid id, string name)
    {
        idProduct = id;
        NewProduct = name;
    }

    private async Task Update(Guid id, string name)
    {
        var product = await GetById(id);
        await ProductAppService.UpdateAsync(id, name);
        NewProduct = "";
        Products = await ProductAppService.GetListAsync();
    }
}
