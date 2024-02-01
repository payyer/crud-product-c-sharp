using System;
using Volo.Abp.Domain.Entities;

namespace ProductDemo2.Products
{
    public class Product : BasicAggregateRoot<Guid>
    {
        public string Name { get; set; }
    }
}
