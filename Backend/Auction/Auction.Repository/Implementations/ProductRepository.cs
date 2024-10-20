using Auction.Repository.Abstractions;
using System.Data.SqlClient;
using System.Data;
using Auction.Domain.Entities;
using Dapper;
using Auction.Domain.Modeles;

namespace Auction.Repository.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private readonly string _connectionString;

        public ProductRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        private IDbConnection Connection => new SqlConnection(_connectionString);

        public async Task<int> DeleteProductAsync(int productId)
        {
            string query = "delete from Products where Id = @Id;";

            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                var result = await dbConnection.ExecuteAsync(query, new {Id = productId});
                return result;
            }
        }

        public async Task<List<ProductEntity>> GetProductsAsync()
        {
            string query = "select Id, Name, Description,StaringPrice, CurrentPrice,EndDate, Image from Products";

            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                var products = await dbConnection.QueryAsync<ProductEntity>(query);
                return products.ToList();
            }
        }

        public async Task<List<ProductEntity>> GetProductsByUser(int userId)
        {
            string query = "select p.Id, Name, Description,StaringPrice, CurrentPrice,EndDate, Image from Products P\r\nJoin ProductUser pu on pu.ProductId = p.Id where pu.UserId=@Id;";

            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                var products = await dbConnection.QueryAsync<ProductEntity>(query, new {Id = userId});
                return products.ToList();
            }
        }

        public async Task<int> UpdateProduct(ProductEntity product)
        {
            string query = "update products set Name = @Name, Description = @Description, StaringPrice = @StaringPrice, CurrentPrice = @CurrentPrice, EndDate = @EndDate where Id= @Id;";

            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                var result = await dbConnection.ExecuteAsync(query, new { Id = product.Id, Name = product.Name, Description = product.Description, StaringPrice  = product.StaringPrice, CurrentPrice = product.CurrentPrice, EndDate = product.EndDate ,});
                return result;
            }
        }
    }
}