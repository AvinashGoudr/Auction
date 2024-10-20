using Auction.Domain.Entities;
using Auction.Domain.Modeles;
using Auction.Repository.Abstractions;
using Auction.Services.Abstractions;

namespace Auction.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<ApiResponseModel<bool>> AddUser(UserDetailsDto userDetailsDto)
        {
            ApiResponseModel<bool> result = new ApiResponseModel<bool>();
            UserEntity userEntity = new UserEntity()
            {
                Id = userDetailsDto.Id,
                Name = userDetailsDto.Name,
                Email = userDetailsDto.Email,
                Password = userDetailsDto.Password,
            };
            var user = await _userRepository.AddUser(userEntity);
            result.Data = user > 0 ? true : false;
            return result;
        }

        public async Task<ApiResponseModel<UserEntity>> GetUserByUserId(int userId)
        {
            ApiResponseModel<UserEntity> result = new ApiResponseModel<UserEntity>();
            var user = await _userRepository.GetUserByUserId(userId);
            result.Data = user;
            return result;
        }

        public async Task<ApiResponseModel<UserEntity>> GetUserByUserName(string userName)
        {

            ApiResponseModel<UserEntity> result = new ApiResponseModel<UserEntity>();
            var user = await _userRepository.GetUserByUserName(userName);
            result.Data = user;
            return result;
        }
    }
}
