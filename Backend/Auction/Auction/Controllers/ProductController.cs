using Auction.Domain.Modeles;
using Auction.Services.Abstractions;
using Auction.Services.Implementations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Auction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route("GetProducts")]
        public async Task<IActionResult> GetProducts()
        {
            return Ok(await _productService.GetProducts());
        }

        [HttpDelete]
        [Route("DeleteProduct")]
        public async Task<IActionResult> DeleteProduct(int productId)
        {
            return Ok(await _productService.DeleteProduct(productId));
        }

        [HttpPost]
        [Route("UpdateProduct")]
        public async Task<IActionResult> UpdateProduct(ProductDto productDto)
        {
            return Ok(await _productService.UpdateProduct(productDto));
        }

        [HttpGet]
        [Route("GetProductsByUserId")]
        public async Task<IActionResult> GetProductsByUser(int userId)
        {
            return Ok(await _productService.GetProductsByUser(userId));
        }
    }
}
