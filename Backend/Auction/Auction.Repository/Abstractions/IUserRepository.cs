using Auction.Domain.Entities;

namespace Auction.Repository.Abstractions
{
    public interface IUserRepository
    {
        Task<UserEntity> GetUserByUserId(int UserId);
        Task<UserEntity> GetUserByUserName(string UserName);
        Task<int> AddUser(UserEntity user);
    }
}
