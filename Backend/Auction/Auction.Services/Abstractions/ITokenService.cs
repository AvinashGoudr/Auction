namespace Auction.Services.Abstractions
{
    public interface ITokenService
    {
        string GenerateToken(string username);
    }
}
