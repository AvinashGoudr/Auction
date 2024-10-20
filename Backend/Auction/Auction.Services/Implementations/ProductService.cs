using Auction.Domain.Entities;
using Auction.Domain.Modeles;
using Auction.Repository.Abstractions;
using Auction.Services.Abstractions;
using System.Collections.Generic;

namespace Auction.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ApiResponseModel<bool>> DeleteProduct(int productId)
        {
            ApiResponseModel<bool> apiResponseModel = new ApiResponseModel<bool>();
            var result = await _productRepository.DeleteProductAsync(productId);   
            apiResponseModel.Data = result > 0 ? true : false;
            apiResponseModel.RequestStatus = true;
            return apiResponseModel;
        }

        public async Task<ApiResponseModel<List<ProductDto>>> GetProducts()
        {
            ApiResponseModel<List<ProductDto>> result = new ApiResponseModel<List<ProductDto>>();
            var products = await _productRepository.GetProductsAsync();
            List<ProductDto> productDtos = new  List<ProductDto>();
            foreach (var product in products)
            {
                productDtos.Add(new ProductDto
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    StaringPrice = product.StaringPrice,
                    CurrentPrice = product.CurrentPrice,
                    EndDate = product.EndDate,
                    Image = product.Image,
                });
            }
            result.Data = productDtos;
            return result;
        }

        public async Task<ApiResponseModel<List<ProductDto>>> GetProductsByUser(int userId)
        {
            ApiResponseModel<List<ProductDto>> result = new ApiResponseModel<List<ProductDto>>();
            var products = await _productRepository.GetProductsByUser(userId);
            List<ProductDto> productDtos = new List<ProductDto>();
            foreach (var product in products)
            {
                productDtos.Add(new ProductDto
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    StaringPrice = product.StaringPrice,
                    CurrentPrice = product.CurrentPrice,
                    EndDate = product.EndDate,
                    Image = product.Image,
                });
            }
            result.Data = productDtos;
            return result;
        }

        public async Task<ApiResponseModel<bool>> UpdateProduct(ProductDto product)
        {
            ApiResponseModel<bool> apiResponseModel = new ApiResponseModel<bool>();
            ProductEntity productEntity = new ProductEntity()
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                StaringPrice = product.StaringPrice,
                CurrentPrice = product.CurrentPrice,
                EndDate = product.EndDate,
            };
            var result = await _productRepository.UpdateProduct(productEntity);
            apiResponseModel.Data = result > 0 ? true : false;
            return apiResponseModel;
        }
    }
}
