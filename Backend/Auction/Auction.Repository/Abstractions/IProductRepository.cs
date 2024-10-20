using Auction.Domain.Entities;
using Auction.Domain.Modeles;

namespace Auction.Repository.Abstractions
{
    public interface IProductRepository
    {
        Task<List<ProductEntity>> GetProductsAsync();
        Task<int> DeleteProductAsync(int productId);
        Task<int> UpdateProduct(ProductEntity product);
        Task<List<ProductEntity>> GetProductsByUser(int userId);

    }
}
