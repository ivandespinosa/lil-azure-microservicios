using Lil.Products.Models;

namespace Lil.Products.DAL
{
    public class ProductsProvider : IProductsProvider
    {
        private List<Product> repo = new();
        public ProductsProvider()
        {
            for(int i = 0; i < 100; i++)
            {
                repo.Add(new Product()
                {
                    Id = (i + 1).ToString(),
                    Name = $"Producto {i + 1}",
                    Price = (double)i * 3.14,
                });
            }
        }

        public Task<Product> GetAsync(string id)
        {
            var product = repo.FirstOrDefault(x => x.Id == id); 
            return Task.FromResult(product);
        }
    }
}
