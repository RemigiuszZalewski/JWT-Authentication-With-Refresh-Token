using Authentication.Domain.Entities;

namespace Authentication.Application.Abstracts;

public interface IUserRepository
{
    Task<User?> GetUserByRefreshTokenAsync(string refreshToken);
}