using Auction.Domain.Modeles;

namespace Auction.Repository.Abstractions
{
    public interface ICommonRepository
    {
        Task<User> GetUserByEmail(string email);
    }
}
