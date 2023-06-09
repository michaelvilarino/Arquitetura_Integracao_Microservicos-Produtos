﻿using GeekBurguer.Products.Contract.Dto;
using GeekBurguer.Products.Infra.Context;
using System.Linq.Expressions;

namespace GeekBurguer.Products.Infra.Repository
{
    public interface IProductsRepository: IBaseRepository<Product>
    {
        Task<List<Product>> GetProductsByStoreNameAsync(string storeName);
        Task<bool> AddProductAsync(Product product);
        void UpdateProduct(Product product);
        Task<List<Item>> GetFullListOfItemsAsync();
        Task<Store> GetStoreByName(string storeName);
        Task<Product> GetProductByFilters(Expression<Func<Product, bool>> filters);
        void RemoveItem(Item item);
        void AddItem(Item item);
        ProductsDbContext GetContext();
    }

}
