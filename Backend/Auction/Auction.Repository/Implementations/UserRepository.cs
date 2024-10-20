using Auction.Domain.Entities;
using Auction.Repository.Abstractions;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace Auction.Repository.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly string _connectionString;

        public UserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        private IDbConnection Connection => new SqlConnection(_connectionString);

        public async Task<int> AddUser(UserEntity user)
        {
            string query = "Insert into Users(Name,Email,Password) Values(@Name,@Email,@Password)";

            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return await dbConnection.ExecuteAsync(query, new { Name = user.Name, Email = user.Email , Password = user.Password });
            }
        }

        public async Task<UserEntity> GetUserByUserId(int userId)
        {
            string query = "SELECT * FROM [Users] WHERE Id = @Id";

            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                var user = await dbConnection.QueryFirstOrDefaultAsync<UserEntity>(query, new { Id = userId });
                return user;
            }
        }

        public async Task<UserEntity> GetUserByUserName(string UserName)
        {
            string query = "SELECT * FROM [Users] WHERE Name = @Name";

            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                var user = await dbConnection.QueryFirstOrDefaultAsync<UserEntity>(query, new { Name = UserName });
                return user;
            }
        }
    }
}
