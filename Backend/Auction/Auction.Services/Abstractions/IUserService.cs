using Auction.Domain.Entities;
using Auction.Domain.Modeles;

namespace Auction.Services.Abstractions
{
    public interface IUserService
    {
        Task<ApiResponseModel<UserEntity>> GetUserByUserId(int userId);
        Task<ApiResponseModel<UserEntity>>  GetUserByUserName(string userName);
        Task<ApiResponseModel<bool>> AddUser(UserDetailsDto userDetailsDto);

    }
}
