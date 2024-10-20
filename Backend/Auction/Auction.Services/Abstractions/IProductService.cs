using Auction.Domain.Entities;
using Auction.Domain.Modeles;

namespace Auction.Services.Abstractions
{
    public interface IProductService
    {
        Task<ApiResponseModel<List<ProductDto>>> GetProducts();
        Task<ApiResponseModel<bool>> DeleteProduct(int productId);
        Task<ApiResponseModel<bool>> UpdateProduct(ProductDto product); 
        Task<ApiResponseModel<List<ProductDto>>> GetProductsByUser(int userId);

    }
}
