using Auction.Domain.Modeles;
using Auction.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Auction.Domain.Entities;
using Dapper;

namespace Auction.Repository.Implementations
{
    public class CommonRepository : ICommonRepository
    {

        private readonly string _connectionString;

        public CommonRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        private IDbConnection Connection => new SqlConnection(_connectionString);

        public async Task<User> GetUserByEmail(string email)
        {
            string query = "SELECT * FROM [Users] WHERE Email = @Email";

            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                var user = await dbConnection.QueryFirstOrDefaultAsync<User>(query, new { Email = email });
                return user;
            }
        }
    }
}
